namespace Magic_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== MAGIC CALCULATOR ===");
            Console.WriteLine("Author: ARJUN");
            Console.WriteLine("Press ENTER to start");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Select an option:");
            Console.WriteLine("1 - Matrix Operations");
            Console.WriteLine("2 - Binary");
            Console.WriteLine("3 - Number Theory");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();

            //@ MATRIX
            if (choice == 1)
            {
                Console.WriteLine("Matrix Mode Activated");
                Console.WriteLine("Enter Matrix A (2*2):\n");
                Console.Write("A11: "); int a11 = int.Parse(Console.ReadLine());
                Console.Write("A12: "); int a12 = int.Parse(Console.ReadLine());
                Console.Write("A21: "); int a21 = int.Parse(Console.ReadLine());
                Console.Write("A22: "); int a22 = int.Parse(Console.ReadLine());
                Console.WriteLine("\nEnter Matrix B (2*2):\n");
                Console.Write("B11: "); int b11 = int.Parse(Console.ReadLine());
                Console.Write("B12: "); int b12 = int.Parse(Console.ReadLine());
                Console.Write("B21: "); int b21 = int.Parse(Console.ReadLine());
                Console.Write("B22: "); int b22 = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1 - Dot Product");
                Console.WriteLine("2 - Scalar Multiply");
                Console.WriteLine("3 - Determinant");
                Console.WriteLine("4 - Inverse");
                int op = int.Parse(Console.ReadLine());
                Console.Clear();

                // DOT PRODUCT
                if (op == 1)
                {
                    Console.WriteLine("Dot Product Result:\n");
                    int c11 = (a11 * b11) + (a12 * b21);
                    int c12 = (a11 * b12) + (a12 * b22);
                    int c21 = (a21 * b11) + (a22 * b21);
                    int c22 = (a21 * b12) + (a22 * b22);
                    Console.WriteLine($"{c11}  {c12}");
                    Console.WriteLine($"{c21}  {c22}");
                }

                // SCALAR MULTIPLICATION
                else if (op == 2)
                {
                    Console.Write("Enter scalar value: ");
                    int s = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nMatrix A scaled:");
                    Console.WriteLine($"{s * a11}  {s * a12}");
                    Console.WriteLine($"{s * a21}  {s * a22}");
                    Console.WriteLine("\nMatrix B scaled:");
                    Console.WriteLine($"{s * b11}  {s * b12}");
                    Console.WriteLine($"{s * b21}  {s * b22}");
                }

                // DETERMINANT
                else if (op == 3)
                {
                    int detA = (a11 * a22) - (a12 * a21);
                    int detB = (b11 * b22) - (b12 * b21);
                    Console.WriteLine($"Determinant of A: {detA}");
                    Console.WriteLine($"Determinant of B: {detB}");
                }

                // INVERSE METHOD

                else if (op == 4)
                {
                    int detA = (a11 * a22) - (a12 * a21);
                    int detB = (b11 * b22) - (b12 * b21);
                    Console.WriteLine("Inverse of Matrix A:");

                    if (detA != 0)
                    {
                        Console.WriteLine($"{(double)a22 / detA}  {(double)-a12 / detA}");
                        Console.WriteLine($"{(double)-a21 / detA} {(double)a11 / detA}");
                    }
                    else Console.WriteLine("No inverse (det = 0)");
                    Console.WriteLine("\nInverse of Matrix B:");

                    if (detB != 0)
                    {
                        Console.WriteLine($"{(double)b22 / detB}  {(double)-b12 / detB}");
                        Console.WriteLine($"{(double)-b21 / detB} {(double)b11 / detB}");
                    }

                    else Console.WriteLine("No inverse (det = 0)");

                }

                // @ Binary

                else if (choice == 2)
                {
                    Console.WriteLine("Enter Binary:");
                    Console.WriteLine("1-Binary to Decimal");
                    Console.WriteLine("2-Decimal to Binary");
                    Console.WriteLine("3-Binary Addition");
                    Console.WriteLine("4-Binary subtraction");
                    int binaryop = int.Parse(Console.ReadLine());
                    Console.Clear();

                    //Binary to Decimal
                    if (binaryop == 1)
                    {
                        Console.WriteLine("Enter Binary Number:");
                        string binarystring = Console.ReadLine();
                        Console.WriteLine($"Decimal= {Convert.ToInt32(binaryop)}");
                    }
                    //Decimal to Binary
                    else if (binaryop == 2) 
                    {
                        Console.WriteLine("Enter binary Number:");
                        int decimalint = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Binary= {Convert.ToString(binaryop)}");
                    }
                    //Binary Addition
                    else if (binaryop==3)
                    {
                        Console.WriteLine("Binary 1:");
                        string x= Console.ReadLine();
                        Console.WriteLine("Binary 2:");
                        string Y= Console.ReadLine();
                        
                        int sum= Convert.ToInt32(x,2)+ Convert.ToInt32(Y,2);
                        Console.WriteLine($"Result = {Convert.ToString(sum,2)}");
                    }
                    else if(binaryop==4)
                    {
                        Console.WriteLine("Binary 1:");
                        string x = Console.ReadLine();
                        Console.WriteLine("Binary 2:");
                        string Y= Console.ReadLine();

                        int diff = Convert.ToInt32(x,2)- Convert.ToInt32(Y,2);
                        Console.WriteLine($"Result = {Convert.ToString(diff,2)}");
                    }
                    //end();
                    
                }

                //Number Theory Mode
                else if (op==3)
                {
                    Console.WriteLine("enter first number(A):");
                    //int a =
                }



                    Console.WriteLine("\nPress ENTER to exit");

                Console.ReadLine();


            }
        }
    }
}

            
        

