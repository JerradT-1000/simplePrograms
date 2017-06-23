/********************************/
/*Program: Simon */
          
/* this program is part of the game simon (says).*/
/*******************************/

import java.util.Scanner;

public class simon {
   public static void main(String[] args){
      Scanner scnr = new Scanner(System.in);

      String simonPattern = "";
      String userPattern = "";
      int userScore = 0;
      int i = 0;

      userScore = 0;
      simonPattern = "RRGBRYYBGY";
      userPattern  = "RRGBBRYBGY";
      
      
      //i is index number
      for (i = 0; i < 10; i++){
      
         
         if (userPattern.charAt(i) == simonPattern.charAt(i)){
            userScore++;
            continue;
            
         }
         else{
            break;
         }
      }
       
      System.out.println("userScore: " + userScore);

      return;
   }
}