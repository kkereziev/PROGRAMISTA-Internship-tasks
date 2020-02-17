# PROGRAMISTA-Internship-tasks

The following solutions are for the internship tasks from PROGRAMISTA;

Task № 1: Brothers in the Bar

The solution for this task is located in BrothersInTheBar\BrothersInTheBar\Program.cs. The solution itself has two methods: CreateArray and 
FindRounds. The CreateArray method creates the array(was thinking of creating list instead but decided to proceed with array). I wasn't quite sure if I'm to create the array via for cycle with given length or to simply console read the array so I did it both ways with the second way currently in use and the first I've put in #region. Right now the CreateArray method is reading the array from the console, splitting the array by ", " and parsing each number to int via Select method.
The second method FindRounds is where we find the number of the rounds. Firstly we create list from the array so we can use the RemoveRange method from the list. This way when we find 3 consecutive glasses we can remove them from the list. I'm using for cycle to loop through the array. The condition list.Count-2 takes care of 2 problems: the first one is that the looping stops if the array has less than 3 elements and the second one is to protect the program from index out of range error because of the if statement. In the if statement we are simply checking if the current element is equal to the next 2 elements. If so we increment the rounds variable, remove the 3 equal elements and start looping from the start of the list.


Task № 2: Java/.NET Assignment(DiscountCards)

The solution for this task is located in DiscountCards\DiscountCards. The entry point is in ProgramRun.cs, the Main method is StartUp.
I've created abstract class DiscountCard with one constructor for the Owner property(private setter ) and the Turnover property(private setter), abstract property DiscountRate(protected setter) and one method Discount to evaluate the discount. I've created 3 classes(GoldCard, BronzeCard, SilverCard) which inherit DiscountCard. All of them are implementing the base constructor, the property DiscountRate and I've also added private field discount so we can set the given task conditions to the setter of DiscountRate. I've created PayDesk class with two methods-PrintCard, which takes 2 arguments(card, purchase) and it is using StringBuilder to output the information.The other method is SumTotalPriceForPurchase, which takes the same arguments as PrintCard and sums the total for the purchase. 

