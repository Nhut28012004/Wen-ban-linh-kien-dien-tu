#define WallMgr 0xFFD6EC
#define EdgWall 0x568
#define WallShoot 0x56C
#define PerfectWall 0x570

void ShootThroughtWall(void){
    DWORD Cshell = (DWORD)GetModuleHandlA("cshell.dll");
    if(Cshell){
        DWORD pWallMgr = *(DWORD*)(Cshell + WallMgr);
        if(pWallMgr){
            for(int i = 0; i < 64; i++){
                *(bool*)(pWallMgr + (i * EdgWall)) = true;
                *(bool*)(pWallMgr + (i * WallShoot)) = true;
                *(bool*)(pWallMgr + (i * PerfectWall)) = true;
            }
        }
    }
}