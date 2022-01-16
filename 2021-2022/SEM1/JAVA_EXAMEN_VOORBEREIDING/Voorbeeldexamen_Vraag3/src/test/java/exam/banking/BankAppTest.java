package exam.banking;

import org.junit.jupiter.api.Test;

import java.util.ArrayList;
import java.util.List;

import static org.junit.jupiter.api.Assertions.*;

public class BankAppTest {
    @Test
    void addClientMakesNewClient(){
        BankApp bankApp = new BankApp();
        BankClient client = bankApp.addClient("Jan Jansens", 500, true);

        assertNotNull(client);
    }

    @Test
    void addClientMakesRightClient(){
        BankApp bankApp = new BankApp();
        BankClient client = bankApp.addClient("Jan Jansens", 500, true);
        BankClient client1 = bankApp.addClient("Jos Jansens", 300, false);

        assertEquals(client.getName(), "Jan Jansens");
        assertEquals(client.getAmount(), 500);
        assertNotNull(client.getCardId());
        assertEquals(client.getState(), ClientState.ACTIVE);

        assertEquals(client1.getName(), "Jos Jansens");
        assertEquals(client1.getAmount(), 300);
        assertNull(client1.getCardId());
        assertEquals(client.getState(), ClientState.ACTIVE);
    }

    @Test
    void addClientWithNameNullResultsInNull(){
        BankApp bankApp = new BankApp();
        BankClient client = bankApp.addClient(null, 500, true);

        assertNull(client);
    }

    @Test
    void addClientBankAppOneClient(){
        BankApp bankApp = new BankApp();
        BankClient client = bankApp.addClient("Jan Jansens", 500, true);

        assertEquals(bankApp.getClients().size(), 1);
    }

    @Test
    void setClientsBankAppHasNewClients(){
        BankApp bankApp = new BankApp();

        BankClient client = bankApp.addClient("Jan Jansens", 500, true);
        List<BankClient> clients = new ArrayList<>();
        clients.add(client);

        bankApp.setClients(clients);

        assertEquals(bankApp.getClients(), clients);
    }

    @Test
    void clientHas500Withdraw100Has400(){
        BankApp bankApp = new BankApp();
        BankClient client = bankApp.addClient("Jan Jansens", 500, true);

        bankApp.withdrawAmount("Jan Jansens", 100);

        assertEquals(client.getAmount(), 400);
    }

    @Test
    void bankAppDisableClientResultsClientIsDisabled(){
        BankApp bankApp = new BankApp();
        BankClient client = bankApp.addClient("Jan Jansens", 500, true);

        bankApp.disableClient("Jan Jansens");

        assertEquals(client.getState(), ClientState.DISABLED);
    }

    @Test
    void clientCantWithdrawIfClientIsDisabled(){
        BankApp bankApp = new BankApp();
        BankClient client = bankApp.addClient("Jan Jansens", 500, true);

        bankApp.disableClient("Jan Jansens");

        boolean succes = bankApp.withdrawAmount("Jan Jansens", 100);

        assertFalse(succes);
    }

    @Test
    void disableClientWithWrongName(){
        BankApp bankApp = new BankApp();
        BankClient client = bankApp.addClient("Jan Jansens", 500, true);

        bankApp.disableClient("Jan Jansen");

        assertEquals(bankApp.getClients().size(), 1);
    }

    @Test
    void clientToStringGivesRightString(){
        BankApp bankApp = new BankApp();
        BankClient client = bankApp.addClient("Jan Jansens", 500, true);

        String clientString = client.toString();

        assertEquals(clientString, "BankClient [name=" + client.getName() + ", amount=" + client.getAmount() + ", cardId=" + client.getCardId() + ", State=" + client.getState() + "]");
    }
}
