# 1 euro - 1,39 dolares
from decimal import Decimal

# 20 euros = 23,77 dolares     20 x 1.19
# 20 dolares = 16.83 euros     20 / 1.19
opcao = ''

while opcao.upper() not in ('S', 'Sair'):  # OU pode colocar lower "s" e tem que alterar no "case"
    print('Escolha a opção')
    print('1 - Euros -> Dolares')
    print('2 - Dolares -> Euros')
    print('Sair')
    print()
    opcao = input('Digite a opcao: ')

    match opcao.upper():  # Vai transformar o "input" em "SAIR" ou "S"
        case '1':
            valor = Decimal(input('Digite o valor em euros: '))
            dolar = valor * Decimal('1.39')
            print('{0} euros são {1:.2f} dolares'.format(valor, dolar))
            print(f'{valor} euros são {dolar:.2f} dolares')
        case '2':
            valor = Decimal(input('Digite o valor em dolares: '))
            euro = valor / Decimal('1.39')
            print('{0} dolares são {1:.2f} euros'.format(valor, euro))
            print(f'{valor} euros são {euro:.2f} dolares')
        case 'S':  # "s"
            print('Sair do programa')
            break
        case _:
            print('Opção inválida')
