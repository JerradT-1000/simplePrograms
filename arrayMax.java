import java.util.Scanner;

public class arrayMax {

   public static void main(String[] args) {
   
      Scanner scnr = new Scanner(System.in);
      final int NUM_ELEMENTS = 8;
      int[] userVals = new int[NUM_ELEMENTS];
      int i = 0;
      int maxVal = 0;
      
      //prompt user to populate array
      System.out.println("Enter " + NUM_ELEMENTS + " integer values...");
      
      for (i = 0; i < NUM_ELEMENTS; i++){
         System.out.print("Value: ");
         userVals[i] = scnr.nextInt();
      }
      
      //Determine largest number
      maxVal = userVals[0];
      
      for (i = 0; i < NUM_ELEMENTS; i++){
         if (userVals[i] > maxVal){
            maxVal = userVals[i];
         }
      }
      System.out.println("Max: " + maxVal);
      
      return;
   }
}