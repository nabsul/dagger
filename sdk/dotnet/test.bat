set MY_VARIABLE=YourDataHere
for /f "delims=" %%a in ('powershell -Command "[Convert]::ToBase64String([System.Text.Encoding]::UTF8.GetBytes(\"%MY_VARIABLE%\"))"') do set ENCODED_VAR=%%a

echo %ENCODED_VAR%
