/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package factorypatternconnection;

/**
 *
 * @author TIENIT
 */
public abstract class FactoryConnection {
    
    public FactoryConnection() {
    }
    
    public abstract IConnection createConnection(String type);
    
}
