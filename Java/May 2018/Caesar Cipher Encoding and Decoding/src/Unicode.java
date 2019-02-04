/*Elise Le Caruyer de Beauvais 
 Ingesup B1 
 */

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class Unicode {


	public static void main(String[] args) {
	/*There is a while true loop to allow the user to continue choosing what they want to do until they are done
	 A menu also appears where the user types in the corresponding number that they want
	 */
		while(true){
		System.out.println("\n----------- Menu ------------ ");
		System.out.println("1 : Transform a text into Ascii");
		System.out.println("2 : Transform Ascii code into text");
		System.out.println("3 : Code a message using Caesar Cipher");
		System.out.println("4 : Translate a Caesar Cipher message");
		System.out.println("5 : Quit");
		Scanner choice = new Scanner(System.in);
		String thechoice = choice.nextLine();
		
		switch(thechoice){
		case "1" :
			Scanner s = new Scanner(System.in);
	        System.out.println("Enter the text that you want to translate into Ascii code :");
	        String text = s.nextLine();
	        char[] message = text.toCharArray();

			
			for(char letters : message){
				char crytpology = letters;
				int c = crytpology;
				System.out.print(c + " ");
			}
			break;

			
		case "2" : 
			Scanner t = new Scanner(System.in);
	        System.out.println("Enter the Ascii code that you want to translate (seperate each code with a space) :");
	        String text2 = t.nextLine();
	        String[] splitcode = text2.split(" ");
	        int[] asciicodes = Arrays.stream(splitcode).mapToInt(Integer::parseInt).toArray();
	        /*Since I accepted the code from the user as a string, I first cut the string after every space and put that into a string array. Then I transformed the string array into an int array*/
	        
	        for(int numbers : asciicodes){
	        	int codedmessage = numbers;
	        	char l = (char)codedmessage;
	        	System.out.print(l);
	        	
	        }
	        break;
	        
	        
	        
		case "3" :
			Scanner z = new Scanner(System.in);
	        System.out.println("Enter the text that you want to translate into Caesar Cipher (Right now this only works with text so please bear with me ) :");
	        String text3 = z.nextLine();
	        String uppercase = text3.toUpperCase();
	        char[] message3 = uppercase.toCharArray();

			
			for(char letters : message3){
				/*Making an exception for spaces. So spaces stay spaces*/
				if(letters == ' '){
					System.out.print(letters);
				}
				else{
				char crytpology = letters;
				int c = crytpology;
				int newascii = c + 3;
				/*Since for the moment I am only working with all caps messages, if the letter is greater than Z which on the ascii code is 90 than the cipher goes back to 65. so if someone where to put in a Z it would become 67*/
				if(newascii > 90){
					newascii = 64 + (newascii - 90);
				}
				
				int codedmessage = newascii;
	        	char l = (char)codedmessage;
	        	System.out.print(l);
				}

			}
			break;
			
		case "4" :
			/*Same code as case 3, the only difference is this one goes back 3 spaces to decode the message*/
			Scanner a = new Scanner(System.in);
	        System.out.println("Enter the Caesar Cipher text you want to translate:");
	        String text4 = a.nextLine();
	        String uppercase2 = text4.toUpperCase();
	        char[] message4 = uppercase2.toCharArray();

			
			for(char letters : message4){
				/*Making an exception for spaces. So spaces stay spaces*/
				if(letters == ' '){
					System.out.print(letters);
				}
				else{
				char crytpology = letters;
				int c = crytpology;
				int newascii = c - 3;
				/*Since for the moment I am only working with all caps messages, if the letter is greater than Z which on the ascii code is 90 than the cipher goes back to 65. so if someone where to put in a Z it would become 67*/
				if(newascii < 65){
					newascii = 90 - (newascii - 65);
				}
				
				int codedmessage = newascii;
	        	char l = (char)codedmessage;
	        	System.out.print(l);
				}

			}
			break;
		case "5" :
			System.exit(0); 
			
		default :
			System.out.println("Please enter a number");
			break;
		}
		
		}		
		
	}

}
