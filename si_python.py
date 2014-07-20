#7 ingredients: Python

#VARIABLES
x=10
y="words, words, words"
z=False

#CONDITIONALS
if x>10:
    print x
else:
    print y

#FUNCTIONS
def hr(x=7):
    y=""
    for i in range(x):
        y+="-"
    print y

hr()

#SETS
a=['Hamlet','The Merchant of Venice','The Taming of the Shrew']
b={"food":"cake","not_food":"not cake"}
print a[0]
print b['food']
a.append('The Scottish Play')
print a[3]
hr()

#LOOPS
for i in a:
    print i

hr(3)

for key in b:
    print key
    print b[key]
    
hr()

#DOCUMENTATION
print "https://docs.python.org/2.7/"
hr()

#EXECUTION
print "open a terminal and type python"
hr()
