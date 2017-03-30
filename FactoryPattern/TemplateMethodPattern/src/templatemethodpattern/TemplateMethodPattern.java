/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package templatemethodpattern;

/**
 *
 * @author TIENIT
 */
public class TemplateMethodPattern {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        AutomotiveRobot autoRobot = new AutomotiveRobot("Automotive Robot");
        
        CookieRobot cookieRobot = new CookieRobot("Cookie Robot");
        
        System.out.println(autoRobot.getName());
        autoRobot.go();
        System.out.println();
        
        System.out.println(cookieRobot.getName());
        cookieRobot.go();
        
    }
    
}
