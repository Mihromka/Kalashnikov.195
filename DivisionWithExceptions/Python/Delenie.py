import sys
print("Int size(bytes)" + str(sys.getsizeof(int)))
print("float size(bytes)" + str(sys.getsizeof(float)))
try:
    num1 = int(input("Enter the first number:"))
    num2 = int(input("Enter the second number:"))
    print("Result:", num1/num2)
except ValueError:
    print("Not a number")
except ZeroDivisionError:
    print("You can't divide zero")
except():
    print("Global exception")
print("The end")
