/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package adapterpattern;

/**
 *
 * @author TIENIT
 */
public class AcmeClass implements AcmeInterface {

    String firstName;
    String lastName;
    
    @Override
    public void setFirstName(String f) {
        this.firstName = f;
    }

    @Override
    public void setLastName(String l) {
        this.lastName = l;
    }

    @Override
    public String getFirstName() {
        return this.firstName;
    }

    @Override
    public String getLastName() {
        return this.lastName;
    }
    
}
