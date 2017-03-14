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
public abstract class ShapeType {

    /**
     * @return the m_R
     */
    public double getM_R() {
        return m_R;
    }

    /**
     * @param m_R the m_R to set
     */
    public void setM_R(double m_R) {
        this.m_R = m_R;
    }

    /**
     * @return the m_W
     */
    public double getM_W() {
        return m_W;
    }

    /**
     * @param m_W the m_W to set
     */
    public void setM_W(double m_W) {
        this.m_W = m_W;
    }

    /**
     * @return the m_H
     */
    public double getM_H() {
        return m_H;
    }

    /**
     * @param m_H the m_H to set
     */
    public void setM_H(double m_H) {
        this.m_H = m_H;
    }

    /**
     * @return the m_A
     */
    public double getM_A() {
        return m_A;
    }

    /**
     * @param m_A the m_A to set
     */
    public void setM_A(double m_A) {
        this.m_A = m_A;
    }
    
    private double m_R;
    private double m_W;
    private double m_H;
    private double m_A;
    
    abstract void draw();
    abstract double getArea();
    abstract double getCircumference();
}
