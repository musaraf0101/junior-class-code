class bill{
    public static void main(String[] args) {
            int pizza = 800;
            int cola_Drink = 150;
            int pepsi_Drink = 100;
            int chiken = 1000;
            int briyani = 750;
            
            Console.WriteLine("Enter pizza quantity");
            int piz = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Cola Drink quantity");
            int cola = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Pepsi quantity");
            int pepsi = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Chiken quantity");
            int chik = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Briyani quantity");
            int bri = Convert.ToInt32(Console.ReadLine());
            
            int subTotal = (pizza * piz)+(cola_Drink*cola)+(pepsi_Drink * pepsi)+(chiken * chik)+(briyani * bri);
            
            double tax;
                if(subTotal<=1000){
                    tax = subTotal*0.03;
                }
                else if(subTotal<=2000){
                    tax = subTotal*0.04;
                }
                else if(subTotal<=5000){
                    tax = subTotal*0.05;
                }
                else{
                    tax = subTotal*0.06;
                }
            
            double Total = subTotal + tax;
            
            Console.WriteLine("Sub Total is : "+subTotal);
            Console.WriteLine("Tax is : "+tax);
            Console.WriteLine("Total is : "+Total);
    }
}