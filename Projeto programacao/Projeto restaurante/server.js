const express = require("express");
const mysql = require("mysql2");
const cors = require("cors");
const path = require("path");
const nodemailer = require("nodemailer");

const app = express();

app.use(express.static(path.join(__dirname, "public")));
app.use(cors());
app.use(express.json());

// Conexão com a base de dados
const conexao = mysql.createConnection({
  host: "localhost",
  user: "root",
  password: "4567",
  database: "ClienteRestaurante",
});

conexao.connect((erro) => {
  if (erro) {
    console.error("Erro na conexão:", erro);
    return;
  }
  console.log("Conexão à base de dados efetuada");
});

// Nodemailer e-mail automático
const transporter = nodemailer.createTransport({
  host: "smtp-mail.outlook.com",
  port: 587,
  secure: false,
  auth: {
    user: "reservas35@hotmail.com",
    pass: "...",
  },
  tls: {
    ciphers: "SSLv3",
    rejectUnauthorized: false,
  },
});

async function enviarEmailConfirmacao({
  nome,
  email,
  data,
  hora,
  pessoas,
  id,
}) {
  const dataFmt = new Date(data + "T12:00:00").toLocaleDateString("pt-PT", {
    weekday: "long",
    year: "numeric",
    month: "long",
    day: "numeric",
  });
  const pLabel = pessoas == 1 ? "pessoa" : "pessoas";
  const numRes = String(id).padStart(5, "0");

  const html = `
  <!DOCTYPE html><html lang="pt"><head><meta charset="UTF-8"></head>
  <body style="margin:0;padding:0;background:#1a1a1a;font-family:Georgia,serif">
  <table width="100%" cellpadding="0" cellspacing="0" style="padding:48px 0">
  <tr><td align="center">
  <table width="560" style="background:#fff;border-radius:2px;overflow:hidden">
    <tr><td style="background:#111;padding:48px;text-align:center">
      <p style="color:#c8a96e;font-size:10px;letter-spacing:0.4em;text-transform:uppercase;margin:0 0 14px;font-family:sans-serif">Reserva Confirmada</p>
      <h1 style="color:#fff;font-size:2rem;font-weight:400;margin:0;font-style:italic">Sabor & Arte</h1>
    </td></tr>
    <tr><td style="padding:40px 48px">
      <p style="font-size:16px;color:#111;margin:0 0 8px">Olá, <strong>${nome}</strong>!</p>
      <p style="font-size:14px;color:#666;line-height:1.7;margin:0 0 32px">A sua reserva foi recebida. Aguardamos a sua visita!</p>
      <table width="100%" style="border-collapse:collapse">
        <tr style="border-bottom:1px solid #f0f0f0">
          <td style="padding:14px 0;font-size:11px;color:#999;letter-spacing:0.15em;text-transform:uppercase;font-family:sans-serif">Nº Reserva</td>
          <td style="padding:14px 0;font-size:14px;color:#c8a96e;font-weight:bold;text-align:right">#${numRes}</td>
        </tr>
        <tr style="border-bottom:1px solid #f0f0f0">
          <td style="padding:14px 0;font-size:11px;color:#999;letter-spacing:0.15em;text-transform:uppercase;font-family:sans-serif">Data</td>
          <td style="padding:14px 0;font-size:14px;color:#111;text-align:right">${dataFmt}</td>
        </tr>
        <tr style="border-bottom:1px solid #f0f0f0">
          <td style="padding:14px 0;font-size:11px;color:#999;letter-spacing:0.15em;text-transform:uppercase;font-family:sans-serif">Hora</td>
          <td style="padding:14px 0;font-size:14px;color:#111;text-align:right">${hora}</td>
        </tr>
        <tr>
          <td style="padding:14px 0;font-size:11px;color:#999;letter-spacing:0.15em;text-transform:uppercase;font-family:sans-serif">Pessoas</td>
          <td style="padding:14px 0;font-size:14px;color:#111;text-align:right">${pessoas} ${pLabel}</td>
        </tr>
      </table>
      <p style="font-size:12px;color:#aaa;margin:28px 0 0;text-align:center">
        Para alterar use o código <strong style="color:#c8a96e">#${numRes}</strong> e o seu e-mail no site.
      </p>
    </td></tr>
    <tr><td style="background:#f9f9f9;padding:20px;text-align:center">
      <p style="font-size:11px;color:#bbb;margin:0;font-family:sans-serif">Reservas · Lisboa · reservas35@hotmail.com</p>
    </td></tr>
  </table>
  </td></tr></table></body></html>`;

  try {
    await transporter.sendMail({
      from: '"Reserva" <reservas35@hotmail.com>',
      to: `"${nome}" <${email}>`,
      subject: `Reserva Confirmada · #${numRes}`,
      html,
    });
    console.log(`E-mail enviado para ${email}`);
  } catch (err) {
    console.error("Erro ao enviar e-mail:", err.message);
  }
}

async function enviarEmailAlteracao({ nome, email, data, hora, pessoas, id }) {
  const dataFmt = new Date(data + "T12:00:00").toLocaleDateString("pt-PT", {
    weekday: "long",
    year: "numeric",
    month: "long",
    day: "numeric",
  });
  const pLabel = pessoas == 1 ? "pessoa" : "pessoas";
  const numRes = String(id).padStart(5, "0");

  const html = `
  <!DOCTYPE html><html lang="pt"><head><meta charset="UTF-8"></head>
  <body style="margin:0;padding:0;background:#1a1a1a;font-family:Georgia,serif">
  <table width="100%" cellpadding="0" cellspacing="0" style="padding:48px 0">
  <tr><td align="center">
  <table width="560" style="background:#fff;border-radius:2px;overflow:hidden">
    <tr><td style="background:#111;padding:48px;text-align:center">
      <p style="color:#c8a96e;font-size:10px;letter-spacing:0.4em;text-transform:uppercase;margin:0 0 14px;font-family:sans-serif">Reserva Alterada</p>
      <h1 style="color:#fff;font-size:2rem;font-weight:400;margin:0;font-style:italic">Sabor & Arte</h1>
    </td></tr>
    <tr><td style="padding:40px 48px">
      <p style="font-size:16px;color:#111;margin:0 0 8px">Olá, <strong>${nome}</strong>!</p>
      <p style="font-size:14px;color:#666;line-height:1.7;margin:0 0 32px">A sua reserva foi atualizada. Seguem os novos detalhes:</p>
      <table width="100%" style="border-collapse:collapse">
        <tr style="border-bottom:1px solid #f0f0f0">
          <td style="padding:14px 0;font-size:11px;color:#999;text-transform:uppercase;letter-spacing:0.15em;font-family:sans-serif">Nova Data</td>
          <td style="padding:14px 0;font-size:14px;color:#111;text-align:right">${dataFmt}</td>
        </tr>
        <tr style="border-bottom:1px solid #f0f0f0">
          <td style="padding:14px 0;font-size:11px;color:#999;text-transform:uppercase;letter-spacing:0.15em;font-family:sans-serif">Nova Hora</td>
          <td style="padding:14px 0;font-size:14px;color:#111;text-align:right">${hora}</td>
        </tr>
        <tr>
          <td style="padding:14px 0;font-size:11px;color:#999;text-transform:uppercase;letter-spacing:0.15em;font-family:sans-serif">Pessoas</td>
          <td style="padding:14px 0;font-size:14px;color:#111;text-align:right">${pessoas} ${pLabel}</td>
        </tr>
      </table>
    </td></tr>
    <tr><td style="background:#f9f9f9;padding:20px;text-align:center">
      <p style="font-size:11px;color:#bbb;margin:0;font-family:sans-serif">Sabor & Arte · Lisboa · reservas@saborarte.pt</p>
    </td></tr>
  </table>
  </td></tr></table></body></html>`;

  try {
    await transporter.sendMail({
      from: '"Reservas" <reservas35@hotmail.com>',
      to: `"${nome}" <${email}>`,
      subject: `Reserva Alterada #${numRes}`,
      html,
    });
  } catch (err) {
    console.error("Erro ao enviar e-mail de alteração:", err.message);
  }
}

// Rotas

// POST Criar reserva
app.post("/reserva", (req, res) => {
  const { nome, email, data, hora, pessoas } = req.body;

  if (!nome || !email || !data || !hora || !pessoas)
    return res.status(400).json({ erro: "Todos os campos são obrigatórios" });

  const sql =
    "INSERT INTO Cliente (Nome, Email, Dia, Hora, Pessoas) VALUES (?, ?, ?, ?, ?)";

  conexao.query(sql, [nome, email, data, hora, pessoas], (erro, resultado) => {
    if (erro) {
      console.error("Erro ao inserir:", erro);
      return res.status(500).json({ erro: "Erro ao guardar reserva" });
    }
    const id = resultado.insertId;
    enviarEmailConfirmacao({ nome, email, data, hora, pessoas, id });
    res.status(201).json({ mensagem: "Reserva efetuada com sucesso!", id });
  });
});

// GET reserva
app.get("/reserva", (req, res) => {
  const { id, email } = req.query;

  if (!id || !email)
    return res.status(400).json({ erro: "ID e e-mail são obrigatórios" });

  const sql = "SELECT * FROM Cliente WHERE ID = ? AND Email = ? LIMIT 1";

  conexao.query(sql, [id, email], (erro, resultados) => {
    if (erro) return res.status(500).json({ erro: "Erro ao buscar reserva" });
    if (resultados.length === 0)
      return res.status(404).json({ erro: "Reserva não encontrada" });
    res.json({ reserva: resultados[0] });
  });
});

// PUT Alterar reserva
app.put("/reserva/:id", (req, res) => {
  const { id } = req.params;
  const { email, data, hora, pessoas } = req.body;

  if (!email || !data || !hora || !pessoas)
    return res.status(400).json({ erro: "Todos os campos são obrigatórios" });

  const sqlVerif = "SELECT * FROM Cliente WHERE ID = ? AND Email = ? LIMIT 1";

  conexao.query(sqlVerif, [id, email], (erro, resultados) => {
    if (erro) return res.status(500).json({ erro: "Erro na base de dados" });
    if (resultados.length === 0)
      return res.status(404).json({ erro: "Reserva não encontrada" });

    const reserva = resultados[0];
    const sqlUpdate =
      "UPDATE Cliente SET Dia = ?, Hora = ?, Pessoas = ? WHERE ID = ?";

    conexao.query(sqlUpdate, [data, hora, pessoas, id], (erroUpd) => {
      if (erroUpd)
        return res.status(500).json({ erro: "Erro ao atualizar reserva" });
      enviarEmailAlteracao({
        nome: reserva.Nome,
        email,
        data,
        hora,
        pessoas,
        id,
      });
      res.json({ mensagem: "Reserva atualizada com sucesso!" });
    });
  });
});

// GET Mostrar reserva
app.get("/reservas", (req, res) => {
  conexao.query(
    "SELECT * FROM Cliente ORDER BY Dia, Hora",
    (erro, resultados) => {
      if (erro)
        return res.status(500).json({ erro: "Erro ao buscar reservas" });
      res.json(resultados);
    },
  );
});

// DELETE Cancelar reserva
app.delete("/reserva/:id", (req, res) => {
  const { id } = req.params;
  const email = req.query.email;
  if (!id || !email)
    return res.status(400).json({ erro: "ID e e-mail são obrigatórios" });

  const sqlVerif = "SELECT * FROM Cliente WHERE ID = ? AND Email = ? LIMIT 1";

  conexao.query(sqlVerif, [id, email], (erro, resultados) => {
    if (erro) return res.status(500).json({ erro: "Erro na base de dados" });
    if (resultados.length === 0)
      return res.status(404).json({ erro: "Reserva não encontrada" });

    conexao.query("DELETE FROM Cliente WHERE ID = ?", [id], (erroDel) => {
      if (erroDel)
        return res.status(500).json({ erro: "Erro ao cancelar reserva" });
      res.json({ mensagem: "Reserva cancelada com sucesso!" });
    });
  });
});

app.listen(3000, () => {
  console.log("Sistema de Reservas");
  console.log("Servidor a correr em http://localhost:3000");
});
