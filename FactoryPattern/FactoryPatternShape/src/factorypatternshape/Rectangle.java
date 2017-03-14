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
public class Rectangle extends ShapeType {

    @Override
    public void draw() {
        System.out.println("factorypatternshape.Rectangle.draw()::");
    }

    @Override
    public double getArea() {
        return this.getM_H() * this.getM_W();
    }

    @Override
    public double getCircumference() {
        return 2 * (this.getM_H() + this.getM_W());
    }

    
}
