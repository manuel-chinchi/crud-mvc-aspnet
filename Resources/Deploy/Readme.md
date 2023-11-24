# Internet Information Services (IIS)

## Desplegar aplicacion hecha en ASP.Net con LocalDB en IIS (paso por paso)

Para poder desplegar una aplicación web hecha en ASP .Net con LocalDB en IIS se requieren
seguir una serie de pasos necesarios para que este efectivamente funciones, a continuación
los pasos son estos.

  1. Activar IIS en Windows. Para esto buscar la opción **Activar o desactivar las 
    características de Windows**  
    luego marcar la casilla **Internet Information Services** y **todas sus subcasiilas** de
    manera que queden como se ve a continuación.

      <p align="center">
        <img src="iis_1.png" width="669px" height="527px">
      </p>

      No debe quedar con la casilla marcada con negro, ya que eso indica que hay alguna subcasilla
      que no esta marcada, por ende, algún componente no fue seleccionado en la activación de IIS.

      <p align="center">
          <img src="iis_2.png" width="600px" height="662px">
      </p>
  
  2. Crear una carpeta en la ubicación `C:\inetpub\wwwroot\` por ej. `mi-sitio` y dejar 
    ahí los archivos del sitio web a probar.

  3. Entrar a IIS, en la sección **Conexiones** > **Agregar sitio web...** y ahí completar 
    los siguientes campos.

        - **Nombre del sitio** nombre cualquiera
        - **Grupo de aplicaciones** nombre cualquiera
        - **Ruta de acceso física** acá va la ruta de la carpeta donde están los arhivos de la
          página. En este caso sería `C:\inetpub\wwwroot\mi-sitio`

  
        Luego elegir un puerto que no este en uso y darle a **Aceptar**, solo estos campos son 
        necesarios para completar.

   4. Ahora modificar el archivo `applicationHost.config` que se encuentra en la ruta
        `C:\Windows\System32\inetsrv\config\`. Dentro del archivo buscar el apartado donde esta
        el campo `<applicationPools>` debería verse algo así.

        ```xml
            <applicationPools>
                <add name="DefaultAppPool" autoStart="true" />
                <add name="Classic .NET AppPool" managedRuntimeVersion="v2.0" managedPipelineMode="Classic" />
                <add name=".NET v2.0 Classic" managedRuntimeVersion="v2.0" managedPipelineMode="Classic" />
                <add name=".NET v2.0" managedRuntimeVersion="v2.0" />
                <add name=".NET v4.5 Classic" managedRuntimeVersion="v4.0" managedPipelineMode="Classic" />
                <add name=".NET v4.5" managedRuntimeVersion="v4.0" />
                <add name="test" />
                <applicationPoolDefaults managedRuntimeVersion="v4.0">
                    <processModel identityType="ApplicationPoolIdentity" loadUserProfile="true" setProfileEnvironment="false" />
                </applicationPoolDefaults>
            </applicationPools>
        ```

        Modificar el apartado `<processModel>` que se ve dejando así. son `loadUserProfile`
        y `setProfileEnvironment` en true


        ```xml
            <applicationPoolDefaults managedRuntimeVersion="v4.0">
                <processModel identityType="ApplicationPoolIdentity" loadUserProfile="true" setProfileEnvironment="true" />
            </applicationPoolDefaults>
        ```
    
   5. Listo, luego en **IIS** > sección **Acciones** > **Examinar sitio web** elegir la 
        opción **Examinar \*:82 (http)** y debería abrirse el navegador (En el caso que el
        sitio tenga configura otro puerto debe figurar ese y no el 82).

