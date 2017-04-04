/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package builderpattern;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

/**
 *
 * @author TIENIT
 */
public class BuilderPattern {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        RobotBuilder builder;
        RobotBuildable robot;
        String response = "a";
        
        System.out.print("Do you want a cookie robot [c] or an automotive robot [a]? ");
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        try {
            response = reader.readLine();
        } catch (IOException e) {
            System.out.println("Error.");
        }
        
        if (response.equals("c")) {
            builder = new CookieRobotBuilder();
        } else {
            builder = new AutomotiveRobotBuilder();
        }
        
        //Start the construction process
        builder.addStart();
        builder.addTest();
        builder.addAssemble();
        builder.addStop();
        
        robot = builder.getRobot();
        robot.go();
    }
    
}
