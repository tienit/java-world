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
public class Square extends ShapeType {

    @Override
    public void draw() {
        System.out.println("factorypatternshape.Square.draw()::");
    }

    @Override
    public double getArea() {
        return this.getM_A() * this.getM_A();
    }

    @Override
    public double getCircumference() {
        return 4 * this.getM_A();
    }
    
}
