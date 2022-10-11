namespace SEN381_API_Group3.models;

public class FamilyClient: Client{
    private FamilyMember[]? familyMembers;

    public FamilyClient(string clientID, string clientName, string clientIDNumber, string clientSurname, string clientAddress, string clientEmail, string clientPhoneNumber, List<Policy> policies, string clientStatus, List<string> clientAdHocNotes, FamilyMember[]? familyMembers) : base(clientID, clientName, clientIDNumber, clientSurname, clientAddress, clientEmail, clientPhoneNumber, policies, clientStatus, clientAdHocNotes)
    {
        this.FamilyMembers = familyMembers;
    }

    public FamilyMember[]? FamilyMembers { get => familyMembers; set => familyMembers = value; }
}