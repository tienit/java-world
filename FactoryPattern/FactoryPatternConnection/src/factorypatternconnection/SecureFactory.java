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
public class SecureFactory extends FactoryConnection {

    @Override
    public IConnection createConnection(String type) {
        if (type.equals("Oracle")) {
            return new SecureOracleConnection("tienit");
        }
        else if (type.equals("SqlServer")) {
            return new SecureSqlServerConnection("tienit");
        }
        else {
            return new SecureMySqlConnection("tienit1");
        }
    }
    
}
