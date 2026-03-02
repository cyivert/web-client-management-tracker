namespace web_client_management_tracker.Models
{
    public class ClientService
    {
        // store clients in memory (NOTE: database can be added later on the future)
        private List<Client> clientList = new List<Client>();
        private int nextId = 1;

        // Add a new newClient to the list
        public List <Client> getAllClient() => clientList;

        //
        // METHOD: addClient
        // DESCRIPTION:
        // This adds a new client ot the clientList.
        // It also assigns a unique Id to the new client by using the nextId variable, which is incremented after each addition.
        // PARAMETERS:
        // Client newClient - The client object that contains the details of the new client to be added.
        // RETURNS: n/a
        //
        public void addClient(Client newClient)
        {
            newClient.Id = nextId++;            // Assign a unique Id to the new client
            clientList.Add(newClient);          // Add the new client to the list
        }

        //
        // METHOD: updateClient
        // DESCRIPTION:
        // This updates an existing client's information in the clientList.
        // It searches for the client with the same Id as the updatedClient and updates its properties if found.
        // PARAMETERS:
        // Client updatedClient - The client object that contains the updated details of the client to be modified.
        // RETURNS: n/a
        //
        public void updateclient(Client updatedClient)
        {
            // Find the existing client in the list by matching the Id
            Client? existingClient = clientList.FirstOrDefault(client => client.Id == updatedClient.Id);

            // If the client is found, update its properties with the new values from updatedClient
            if (existingClient != null)
            {
                existingClient.Name = updatedClient.Name;
                existingClient.Email = updatedClient.Email;
                existingClient.Goal = updatedClient.Goal;
                existingClient.StartDate = updatedClient.StartDate;
            }
        }

        //
        // METHOD: deleteClient
        // DESCRIPTION:
        // This deletes a client from the clientList based on the client's Id.
        // It searches for the client with the same Id as the clientId and removes it from the list if found.
        // PARAMETERS:
        // Client clientId - The client object that contains the Id of the client to be deleted.
        // RETURNS: n/a
        public void deleteClient(Client clientId)
        {
            // Find the client in the list by matching the Id
            Client? clientToDelete = clientList.FirstOrDefault(client => client.Id == clientId.Id);

            // If the client is found, remove it from the list
            if (clientToDelete != null)
            {
                clientList.Remove(clientToDelete);
            }
        }
    }
}
