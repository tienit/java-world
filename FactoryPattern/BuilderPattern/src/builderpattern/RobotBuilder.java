/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package builderpattern;

/**
 *
 * @author TIENIT
 */
public interface RobotBuilder {
    public void addStart();
    public void addGetParts();
    public void addAssemble();
    public void addTest();
    public void addStop();
    public RobotBuildable getRobot();
}
