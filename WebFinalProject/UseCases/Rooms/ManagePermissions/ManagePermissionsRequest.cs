namespace WebFinalProject.UseCases.Rooms.ManagePermissions;

public record ManagePermissionsRequest(
    Guid RequesterUserID,  
    Guid RoomID,
    Guid TargetUserID,     
    Guid RoleID            
);