/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package decoratorpatternhouse;

/**
 *
 * @author TIENIT
 */
public class DecoratorPatternHouse {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        //Build a new house
        House house = new House();
        //After 2 year, have money, build 2nd floor
        house = new BuildSecondFloor(house);
        //After 1 year, have more money, build 3rd floor
        house = new BuildThirdFloor(house);
        
        System.out.println("After 4 years, I have " + house.description());
        
    }
    
}
