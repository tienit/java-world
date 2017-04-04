/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package builderpattern;

import java.util.ArrayList;

/**
 *
 * @author TIENIT
 */
public class AutomotiveRobotBuilder implements RobotBuilder {

    AutomotiveRobotBuildable robot;
    ArrayList actions;
    
    public AutomotiveRobotBuilder() {
        robot = new AutomotiveRobotBuildable();
        actions = new ArrayList<>();
    }
    
    @Override
    public void addStart() {
        actions.add(1);
    }

    @Override
    public void addGetParts() {
        actions.add(2);
    }

    @Override
    public void addAssemble() {
        actions.add(3);
    }

    @Override
    public void addTest() {
        actions.add(4);
    }

    @Override
    public void addStop() {
        actions.add(5);
    }

    @Override
    public RobotBuildable getRobot() {
        robot.loadActions(actions);
        return robot;
    }
    
}
