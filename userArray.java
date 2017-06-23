/* THIS WORK BELONGS TO JERRAD STUTZMAN*/
/********************************/
/*Program: rndArray */
/*CIS163AA             */
/*Elliot Cherner       */
/*06/19/2017           */
/* this program makes an array with user parameters*/
/*******************************/
import java.util.Scanner;

public class rndArray {
   public static void main(String[] args){
   Scanner scnr = new Scanner(System.in);
   
   int i;
   
   //prompt user for array parameters
   System.out.println("Enter number of elements (at most 10) to create array: ");
   int numElements = scnr.nextInt();
   
   if (numElements > 10){
      return;
      }
   
   //create array with user parameters
   int[] userArray = new int[numElements];
   
   //get element values from user
   System.out.println("Enter " + numElements + " numbers to put into your array:");
   for (i = 0; i < numElements; i++){
      System.out.print("Value " + (i + 1) + ": ");
      userArray[i] = scnr.nextInt();
      }
      
   //print array
   System.out.println("Your array:");
   for (i = 0; i < numElements; i++){
   System.out.print(userArray[i] + " ");
   }  
   
   }
}