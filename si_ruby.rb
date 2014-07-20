#Seven Ingredients: Ruby

#VARIABLES
x=10
y="some words"
z=false

puts x

#METHODS (FUNCTIONS)
def hr(x=7)
    d=""
    x.times do
        d+="-"
    end
    puts d
end

hr()

#CONDITIONALS
if (x>10)
    puts y
else
    puts x
end
hr()

#SETS

a=["Luke","Leia","Han"]
puts a[0]

b={"first"=>"uno", "second"=>"dos"}
puts b['first']

hr()

#LOOPS
a.each{ |n| puts n}
hr(3)

b.each do |key,val|
    puts "#{key} is #{val}"
end
hr(3)

3.times do
    puts "tres"
end

hr()

#DOCUMENTATION
puts "https://www.ruby-lang.org/en/documentation/"

#EXECUTION
puts "in the terminal type irb or c9.io"