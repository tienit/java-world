/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package builderpattern;

import java.util.*;

/**
 *
 * @author TIENIT
 */
public class AutomotiveRobotBuildable implements RobotBuildable {
    ArrayList actions;
    
    public AutomotiveRobotBuildable() {
    }

    @Override
    public void go() {
        Iterator itr = actions.iterator();
        while (itr.hasNext()) {
            switch((Integer)itr.next()) {
                case 1:
                    start();
                    break;
                case 2:
                    getParts();
                    break;
                case 3:
                    assemble();
                    break;
                case 4:
                    test();
                    break;
                case 5:
                    stop();
                    break;
            }
        }
    }
    
    public void start() {
        System.out.println("Starting ...");
    }
    
    public void getParts() {
        System.out.println("Getting a carburetor ...");
    }
    
    public void assemble() {
        System.out.println("Installing a carburetor ...");
    }
    
    public void test() {
        System.out.println("Revving the engine ...");
    }
    
    public void stop() {
        System.out.println("Stopping ...");
    }
    
    public void loadActions(ArrayList a) {
        this.actions  = a;
    }
}
