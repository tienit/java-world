/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package factorypatterndesign;

/**
 *
 * @author tiennu
 * Khai báo lớp Cat
 * Thuộc loại Pet
 */
public class Cat extends Pet{

    @Override
    public Pet giveBirth() {
        return new Cat();
    }

    @Override
    public void talk() {
        System.out.println("Meo meo");
    }
    
}
