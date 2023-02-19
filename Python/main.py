print("Calcular o IMC (Índice de massa corporal de uma pessoa)")

altura = input("Informe sua altura: ")
altura = float(altura.replace(",", "."))
peso = input("Informe seu peso: ")
peso = float(peso.replace(",", "."))

imc = peso / (altura * altura)
imc_formatado = "{:.2f}".format(imc)

print(f"Seu IMC é: ", imc_formatado)

if imc < 16:
    print("> Magreza Grau III")
if imc > 16 and imc < 16.9:
    print("> Magreza Grau II")
if imc > 17 and imc < 18.4:
    print("> Magreza Grau I")
if imc > 18.5 and imc < 24.9:
    print("> Eutrofia")
if imc > 25 and imc < 29.9:
    print("> Sobrepeso")
    print("> Risco: Aumentado")
if imc > 30 and imc < 34.9:
    print("> Obesidade grau I")
    print("> Risco: Moderado")
if imc > 35 and imc < 40:
    print("> Obesidade grau II")
    print("> Risco: Grave")
if imc > 40:
    print("> Obesidade grau III")
    print("> Risco: Muito Grave")