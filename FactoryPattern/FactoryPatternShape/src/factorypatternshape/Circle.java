/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package factorypatternshape;

/**
 *
 * @author tiennu
 */
public class Circle extends ShapeType {

    @Override
    public void draw() {
        System.out.println("factorypatternshape.Circle.draw()::");
    }

    @Override
    public double getArea() {
        return Math.PI * this.getM_R() * this.getM_R();
    }

    @Override
    public double getCircumference() {
        return 2 * Math.PI * this.getM_R();
    }
    
}
