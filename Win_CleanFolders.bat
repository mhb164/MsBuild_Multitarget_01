@Echo off

echo [92m Start: Clear bin and obj folders [0m

FOR /F "tokens=*" %%G IN ('DIR /B /AD /S bin') DO (    
    RMDIR /S /Q "%%G"
    echo [96m - %%G [91m removed [0m
)

echo:

FOR /F "tokens=*" %%G IN ('DIR /B /AD /S obj') DO (
    RMDIR /S /Q "%%G"
    echo [96m - %%G [91m removed [0m
)

echo Finished
