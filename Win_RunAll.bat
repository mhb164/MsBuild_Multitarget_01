@Echo off

FOR /F "tokens=*" %%G IN ('DIR /B /A /S MsBuild_Multitarget_01.exe') DO (    
    echo [92m - Start %%G  [0m
    %%G
    echo:
)

