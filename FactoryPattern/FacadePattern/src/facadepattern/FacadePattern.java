/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package facadepattern;

/**
 *
 * @author TIENIT
 */
public class FacadePattern {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        SimpleProductFacade facade = new SimpleProductFacade();
        
        facade.setName("Printer");
        
        System.out.println("This is a " + facade.getName());
        
    }
    
}
