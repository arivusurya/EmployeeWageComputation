namespace EmployeWage{

    public class employeeCheck{
        public static void checkemplyee(){
            Random random  = new Random();
            int number = random.Next(2);
            if (number == 1){
                Console.WriteLine("employee is present");

            }else{
                Console.WriteLine("employe is absent");
            }
        }
    }
}