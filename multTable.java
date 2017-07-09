import java.util.Scanner;

public class multTable {
   public static void main(String[] args){
      Scanner scnr = new Scanner(System.in);
      
      double product = 0;
      int tableSize;
   
      System.out.println("How many multiples would you like to display?");
      tableSize = scnr.nextInt();
      
      System.out.println("Enter a number to view it's multiplication table: ");
      double num = scnr.nextDouble();
      
      for (int i = 0; i < tableSize + 1; i++){
         product = num * i;
         System.out.println(num + " * " + i + " = " + product);
      }
      
   return;
   }
}
   