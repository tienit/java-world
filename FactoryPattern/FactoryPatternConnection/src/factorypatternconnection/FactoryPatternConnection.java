/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package factorypatternconnection;

/**
 *
 * @author TIENIT
 */
public class FactoryPatternConnection {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        SecureFactory sf = new SecureFactory();
        
        IConnection conn =  sf.createConnection("Oracle");
        System.out.println("You're connecting to " + conn.description());
        
        conn = sf.createConnection("SqlServer");
        System.out.println("You're connecting to " + conn.description());
        
        conn = sf.createConnection("");
        System.out.println("You're connecting to " + conn.description());
        
    }
    
}
