const hoje = new Date().toISOString().split("T")[0];
const inputData = document.getElementById("data");
const inputEditData = document.getElementById("edit-data");
if (inputData) inputData.min = hoje;
if (inputEditData) inputEditData.min = hoje;

window.addEventListener("scroll", () => {
  const nav = document.getElementById("menu-principal");
  if (nav) {
    nav.style.background =
      window.scrollY > 60 ? "rgba(0, 0, 0, 0.8)" : "rgba(0, 0, 0, 0.8)";
  }
});

const menuToggle = document.getElementById("menu-toggle");
const navUl = document.querySelector("#menu-principal ul");
if (menuToggle && navUl) {
  menuToggle.addEventListener("click", () => {
    const aberto = navUl.style.display === "flex";
    navUl.style.cssText = aberto
      ? ""
      : "display:flex;flex-direction:column;position:absolute;top:72px;left:0;right:0;background:#1a1a1a;padding:24px;gap:20px;border-bottom:1px solid rgba(255,255,255,0.06)";
  });
}

function mostrarMensagem(id, duracao = 5000) {
  const el = document.getElementById(id);
  if (!el) return;
  el.style.display = "block";
  setTimeout(() => {
    el.style.display = "none";
  }, duracao);
}

function esconderMensagem(id) {
  const el = document.getElementById(id);
  if (el) el.style.display = "none";
}

// Criar reserva
document
  .getElementById("formulario-reserva")
  .addEventListener("submit", async function (e) {
    e.preventDefault();

    const reserva = {
      nome: document.getElementById("nome").value.trim(),
      email: document.getElementById("email").value.trim(),
      data: document.getElementById("data").value,
      hora: document.getElementById("hora").value,
      pessoas: parseInt(document.getElementById("pessoas").value),
    };

    esconderMensagem("mensagem-reserva-efetuada");
    esconderMensagem("mensagem-erro");

    const btn = document.getElementById("botao-reservar");
    btn.disabled = true;
    btn.querySelector(".botao-criar-reserva").style.display = "none";
    btn.querySelector(".botao-loader").style.display = "inline";

    try {
      const resposta = await fetch("/reserva", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(reserva),
      });

      const resultado = await resposta.json();

      if (resposta.ok) {
        this.reset();
        const msgEl = document.getElementById("mensagem-reserva-efetuada");
        msgEl.textContent = `Reserva #${String(resultado.id).padStart(5, "0")} efetuada! Verifique o seu e-mail para a confirmação.`;
        mostrarMensagem("mensagem-reserva-efetuada", 8000);
      } else {
        mostrarMensagem("mensagem-erro");
      }
    } catch (erro) {
      console.error("Erro:", erro);
      mostrarMensagem("mensagem-erro");
    } finally {
      btn.disabled = false;
      btn.querySelector(".botao-criar-reserva").style.display = "inline";
      btn.querySelector(".botao-loader").style.display = "none";
    }
  });

// Alteração da reserva
async function buscarReserva() {
  const id = document.getElementById("busca-id").value.trim();
  const email = document.getElementById("busca-email").value.trim();

  esconderMensagem("mensagem-procurar-erro");

  if (!id || !email) {
    const msgEl = document.getElementById("mensagem-procurar-erro");
    msgEl.textContent = "Por favor preencha o número de reserva e o e-mail.";
    mostrarMensagem("mensagem-procurar-erro");
    return;
  }

  const btn = document.getElementById("botao-buscar");
  btn.disabled = true;
  btn.textContent = "A procurar...";

  try {
    const resposta = await fetch(
      `/reserva?id=${encodeURIComponent(id)}&email=${encodeURIComponent(email)}`,
    );
    const resultado = await resposta.json();

    if (resposta.ok && resultado.reserva) {
      const r = resultado.reserva;
      document.getElementById("novo-id").value = r.ID;
      document.getElementById("novo-email").value = r.Email;
      document.getElementById("nova-data").value = r.Dia
        ? r.Dia.split("T")[0]
        : "";
      document.getElementById("novo-horario").value = r.Hora
        ? r.Hora.substring(0, 5)
        : "";
      document.getElementById("novo-numero-pessoas").value = r.Pessoas;
      document.getElementById("alterar-nome").textContent = r.Nome;

      document.getElementById("pesquisar-formulario").style.display = "none";
      document.getElementById("alterar-formulario").style.display = "block";
    } else {
      const msgEl = document.getElementById("mensagem-procurar-erro");
      msgEl.textContent =
        resultado.erro || "Reserva não encontrada. Verifique os dados.";
      mostrarMensagem("mensagem-procurar-erro");
    }
  } catch (erro) {
    console.error("Erro:", erro);
    const msgEl = document.getElementById("mensagem-procurar-erro");
    msgEl.textContent = "Erro ao contactar o servidor.";
    mostrarMensagem("mensagem-procurar-erro");
  } finally {
    btn.disabled = false;
    btn.textContent = "Procurar Reserva";
  }
}

function cancelarEdicao() {
  document.getElementById("alterar-formulario").style.display = "none";
  document.getElementById("pesquisar-formulario").style.display = "flex";
  document.getElementById("busca-id").value = "";
  document.getElementById("busca-email").value = "";
  esconderMensagem("mensagem-reserva-alterada");
  esconderMensagem("mensagem-reserva-alterada-erro");
}

// Alteração das informações da reserva
document
  .getElementById("alteracao-formulario")
  .addEventListener("submit", async function (e) {
    e.preventDefault();

    const id = document.getElementById("novo-id").value;
    const email = document.getElementById("novo-email").value;
    const data = document.getElementById("nova-data").value;
    const hora = document.getElementById("novo-horario").value;
    const pessoas = parseInt(
      document.getElementById("novo-numero-pessoas").value,
    );

    esconderMensagem("mensagem-reserva-alterada");
    esconderMensagem("mensagem-reserva-alterada-erro");

    const btn = document.getElementById("botao-alteracao");
    btn.disabled = true;
    btn.innerHTML = "<span class='botao-loader'>A guardar...</span>";

    try {
      const resposta = await fetch(`/reserva/${id}`, {
        method: "PUT",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ email, data, hora, pessoas }),
      });

      const resultado = await resposta.json();

      if (resposta.ok) {
        mostrarMensagem("mensagem-reserva-alterada", 7000);
        document.getElementById("alteracao-formulario").reset();
      } else {
        const msgEl = document.getElementById("mensagem-reserva-alterada-erro");
        msgEl.textContent =
          resultado.erro || "Erro ao atualizar. Tente novamente.";
        mostrarMensagem("mensagem-reserva-alterada-erro");
      }
    } catch (erro) {
      console.error("Erro:", erro);
      mostrarMensagem("mensagem-reserva-alterada-erro");
    } finally {
      btn.disabled = false;
      btn.innerHTML =
        "<span class='botao-criar-reserva'>Guardar Alterações</span>";
    }
  });

async function cancelarReserva() {
  const id = document.getElementById("novo-id").value;
  const email = document.getElementById("novo-email").value;

  if (!confirm("Tem a certeza que deseja cancelar a reserva?")) return;

  try {
    const resposta = await fetch(
      `/reserva/${id}?email=${encodeURIComponent(email)}`,
      {
        method: "DELETE",
        headers: { "Content-Type": "application/json" },
      },
    );

    const resultado = await resposta.json();

    if (resposta.ok) {
      alert("Reserva cancelada com sucesso.");
      cancelarEdicao();
    } else {
      alert(resultado.erro || "Erro ao cancelar.");
    }
  } catch (erro) {
    console.error("ERRO COMPLETO:", erro);
    alert("Erro ao servidor.");
  }
}
