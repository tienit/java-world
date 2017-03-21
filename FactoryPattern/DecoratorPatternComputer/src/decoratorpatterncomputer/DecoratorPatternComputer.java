/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package decoratorpatterncomputer;

/**
 *
 * @author TIENIT
 */
public class DecoratorPatternComputer {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        Computer com = new Computer();
        com = new Disk(com);
        com = new Monitor(com);
        
        System.out.println("You're getting a " + com.description());
        
    }
    
}
