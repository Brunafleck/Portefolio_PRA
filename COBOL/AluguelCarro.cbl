      ******************************************************************
      * Author:
      * Date:
      * Purpose:
      * Tectonics: cobc
      ******************************************************************
       IDENTIFICATION DIVISION.
       PROGRAM-ID. ALUGUELCARRO.
       DATA DIVISION.
       FILE SECTION.
       WORKING-STORAGE SECTION.
       77 MODELO-DO-CARRO      PIC 9.
           88 VALIDAR-MODELO-DO-CARRO    VALUES 1 THRU 3.
       77 KMS                  PIC 9(5).
       77 NUMERO-DIAS          PIC 9(3).
       77 TOTAL-ILIQUIDO        PIC 9(7)V99.
       77 IVA                  PIC 9(7)V99.
       77 TOTAL-COM-IVA        PIC 9(7)V99.
       77 SAIDA                PIC Z,ZZZ,ZZ9.99.
       77 TEMP-KMS             PIC X(5).
       77 TEMP-DIAS            PIC X(3).
       77 REPETIR              PIC A.
       SCREEN SECTION.
       01 CLS BLANK SCREEN.
       PROCEDURE DIVISION.
       INICIO.
           DISPLAY CLS.
       MAIN-PROCEDURE.
       LER-MODELO-DO-CARRO.
           DISPLAY "DIGITE O MODELO DO CARRO (1) VOLKSWAGEN " &
           "(2) TOYOTA (3) MERCEDES:" FOREGROUND-COLOR 2 HIGHLIGHT
           AT 0101.
           ACCEPT MODELO-DO-CARRO AT 0165.
           IF(NOT VALIDAR-MODELO-DO-CARRO) THEN
               DISPLAY "TIPO DE CARRO NAO EXISTE!" AT 0169
               FOREGROUND-COLOR 4 HIGHLIGHT
           GO MAIN-PROCEDURE
           ELSE
               DISPLAY "  " ERASE EOL AT 0169
               EVALUATE MODELO-DO-CARRO
                   WHEN 1
                       DISPLAY "VOLKSWAGEN" AT 0169 FOREGROUND-COLOR 3
                       HIGHLIGHT
                   WHEN 2
                       DISPLAY "TOYOTA" AT 0169 FOREGROUND-COLOR 3
                       HIGHLIGHT
                   WHEN 3
                       DISPLAY "MERCEDES" AT 0169 FOREGROUND-COLOR 3
                       HIGHLIGHT
               END-EVALUATE
           END-IF.
       LER-QUILOMETROS.
           DISPLAY "QUILOMETROS RODADOS:" AT 0301 FOREGROUND-COLOR 3
           HIGHLIGHT.
           ACCEPT TEMP-KMS AT 0321.
           MOVE FUNCTION NUMVAL(TEMP-KMS) TO KMS.
       LER-NUMERO-DIAS.
           DISPLAY "NUMERO DE DIAS:"       AT 0501.
           ACCEPT TEMP-DIAS AT 0516.
           MOVE FUNCTION NUMVAL(TEMP-DIAS) TO NUMERO-DIAS.
       CALCULO.
           IF(KMS>75) SUBTRACT 75 FROM KMS.
           EVALUATE MODELO-DO-CARRO
               WHEN 1
                   COMPUTE TOTAL-ILIQUIDO=(30 * NUMERO-DIAS + 1.20 *
                   KMS)
               WHEN 2
                   COMPUTE TOTAL-ILIQUIDO=(35 * NUMERO-DIAS + 1.50 *
                   KMS)
               WHEN 3
                   COMPUTE TOTAL-ILIQUIDO=(60 * NUMERO-DIAS + 2.50 *
                   KMS)
           END-EVALUATE.
           COMPUTE IVA=(TOTAL-ILIQUIDO * 0.23).
           COMPUTE TOTAL-COM-IVA=(TOTAL-ILIQUIDO + IVA).

           MOVE TOTAL-ILIQUIDO TO SAIDA.
           DISPLAY FUNCTION CONCATENATE("ILIQUIDO:", SAIDA) AT 0701.
           MOVE IVA TO SAIDA.
           DISPLAY FUNCTION CONCATENATE("IVA:", SAIDA) AT 0901.
           MOVE TOTAL-COM-IVA TO SAIDA.
           DISPLAY FUNCTION CONCATENATE("FINAL:", SAIDA) AT 1101.
           DISPLAY "PRETENDE CONTINUAR (S ou N):" AT 1301.
           ACCEPT REPETIR AT 1329.
           IF(REPETIR="S" OR REPETIR="s") THEN
               GO INICIO
           ELSE
               DISPLAY "OBRIGADO!" AT 1501 FOREGROUND-COLOR 3
               HIGHLIGHT
           END-IF.
           ACCEPT OMITTED AT 1601.
            STOP RUN.
       END PROGRAM ALUGUELCARRO.
