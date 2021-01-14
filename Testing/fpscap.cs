// --------------- NOTES AND CREDITS -------------- 
// FPS UNCAPPER FOR BEDROCK MC BY PRINGLE#0555
// Original credits to LIKETOACCESS for the python script.
// --------------- NOTES AND CREDITS -------------- 

// --------------- RELEASE OF PYTHON VERSION -------------- 
// https://github.com/LikeToAccess/NO-CAP/releases/tag/v1.0
// --------------- RELEASE OF PYTHON VERSION -------------- 

namespace Namespace {
    
    using os;
    
    using sys;
    
    using System.Collections.Generic;
    
    public static class Module {
        
        public static object args = sys.argv;
        
        public static object vsync = args[1];
        
        public static object max_framerate = args[2];
        
        public static object max_framerate = 0;
        
        public static object vsync = 0;
        
        public static object max_framerate = 0;
        
        public static object path = os.getcwd();
        
        static Module() {
            file.write("cd \"%appdata%/../Local/Packages/Microsoft.MinecraftUWP_8wekyb3d8bbwe/LocalState/games/com.mojang/minecraftpe\"\ncopy options.txt %1\\options.txt\ncd %1");
            os.system("grab.cmd {path}");
            os.remove("grab.cmd");
            new_lines.append(line);
            file.write(lines);
            file.write("cd \"%appdata%/../Local/Packages/Microsoft.MinecraftUWP_8wekyb3d8bbwe/LocalState/games/com.mojang/minecraftpe\"\ncopy %1\\options.txt options.txt\ncd %1");
            os.system("send.cmd {path}");
            os.remove("send.cmd");
            os.remove("options.txt");
        }
        
        public static object lines = file.read().split("\n");
        
        public static object new_lines = new List<object>();
        
        public static object line = "gfx_vsync:{vsync}";
        
        public static object line = "gfx_max_framerate:{max_framerate}";
        
        public static object lines = "\n".join(new_lines);
    }
}
