print("Hello World")
a = "Ey Ey Ey"
print(a)
name = input("Tell me your name: ")
print("Hello", name)
print("let's do some maths, okey?")


while True:
    b = float(input("put a number: "))
    c = float(input("put another: "))
    option = int(input("choose the number of one option: \n 1.ADD \n 2.SUB \n 3.DIVIDE \n 4.MULTIPLY \n 5.EXIT \n")) 

    if option == 1:
        print("The ADD is: ", b + c)   
    if option == 2:
        print("The SUBSTRACT is: ", b - c)  
    if option == 3:
        if b and c != 0:
            print("The DIVIDE is: ", b / c)  
        else:
            print("Can't divide by zero")
    if option == 4:
        print("The MULTIPLY is: ", b * c)  
    if option == 5:
        print("okey, exiting")
        break
    if option < 1 or option > 6:
        print("This option is invalid, try again")