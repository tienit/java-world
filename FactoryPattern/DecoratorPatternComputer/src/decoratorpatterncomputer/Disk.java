/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package decoratorpatterncomputer;

/**
 *
 * @author TIENIT
 */
public class Disk extends ComponentDecorator {
    
    Computer com;
    
    public Disk(Computer c) {
        this.com = c;
    }

    @Override
    public String description() {
        return com.description() + " and a disk";
    }
    
}
