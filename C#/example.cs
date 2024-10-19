  int c = 15;
      --c;
      /*
        c=15;
        1st step -> pre decrement
        2nd step -> print
        c=14
      */
      Console.WriteLine(c++);
      /*
        c=14;
        1st step -> print
        2nd step -> increment
            memory value =15;
      */
      c--;
      /*
        c=15;
        1st step -> print
        2nd step ->  decrement
        c=14;
      */
      Console.WriteLine(++c);
      /*
        c=14;
        1st step -> increment
        2nd step -> print
        c=15;
      */
      Console.WriteLine(++c + --c);
      Console.WriteLine(c);


      /* array*/
      /*---------------------------------------*/

      string [] car = {"BMW","Audi","Tesla","Toyota","Ferari","Mustage","GTR","Supra"};
    for(int i=0;i<=7;i++){
        Console.WriteLine(car[i]);
    }



    /* Create a array */

    /*----------------------------*/
     string [] food = new string[6]{"pizza","buger","chiken","cola","pepsi","briyani"};
    
        for(int i=0;i<=5;i++){
        Console.WriteLine(food[i]);
    }



    /* array sort*/


    string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Array.Sort(cars);
foreach (string i in cars)
{
  Console.WriteLine(i);
}


/* array function*/

    int [] food ={3,2,6,4,1,5};
    Console.WriteLine(food.Max());
    Console.WriteLine(food.Min());

/* access one letter from a string */
    string name = "welcome to chrome website";
    Console.WriteLine(name[8]);