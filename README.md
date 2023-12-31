# Ejemplo de uso de controles para la visualización de páginas web

<details>
<summary>Ejemplo de ayuda web </summary>

<p>El ejemplo de prueba es el siguiente:</p><br/>
<div align="center">
        <img style="width:300px;" src="Ejemplos_visualizadorWeb/EjemploAyuda/docs/pantallazo1.jpg"/>
</div>

<p>El documento de ayuda web se muestra así:</p><br/>
<div align="center">
        <img style="width:300px;" src="Ejemplos_visualizadorWeb/EjemploAyuda/docs/pantallazo2.jpg"/>
</div>

```csharp
        //ventana modal
        private void FormVerAyuda_Load(object sender, EventArgs e)
        {
            // caso de no incluir los documentos de ayuda en la compilación!
            // string path = Path.Combine(Application.StartupPath,"..","..","ayuda", "index.html");
            //
            // si se ha incluido los documentos de ayuda en la compilación
            string path = Path.Combine(Application.StartupPath,"ayuda", "index.html");
            //
            webBrowser1.Navigate(path);
        }
```
</details>

<details>
<summary>Ejemplos WebBrowser</summary>

<div style="text-align:center"><br/>
<div align="center">
        <img style="width:200px;" src="Ejemplos_visualizadorWeb/WebBrowser/docs/pantallazo.jpg"/>
</div>

<p>Para el caso de usar el control WebBrowser:</p>
  
```csharp
        private void btnVerHTML_Click(object sender, EventArgs e)
        {
            string pathRootWeb = Application.StartupPath + @"\..\..\web";

            GenHTML gen = new GenHTML();
            string pathListado = gen.GenerarListadoHTML(pathRootWeb, listado);

            FormInformeWeb fInformeWeb = new FormInformeWeb();
            fInformeWeb.webBrowser1.Navigate(pathListado);
            fInformeWeb.ShowDialog();
        }
```
</details>
        
<details open>
<summary>Ejemplos WebView2 </summary>
<p>Para el caso de usar el control WebView2:</p>

<div style="text-align:center"><br/>
<div align="center">
        <img style="width:200px;" src="Ejemplos_visualizadorWeb/WebView/docs/pantallazo.jpg"/>
</div>

```csharp
        private void btnVerHTML_Click(object sender, EventArgs e)
        {
            string pathRootWeb = Application.StartupPath + @"\..\..\web";

            GenHTML gen = new GenHTML();
            string pathListado = gen.GenerarListadoHTML(pathRootWeb, listado);

            FormInformeWeb fInformeWeb = new FormInformeWeb();
            fInformeWeb.webView21.Source = new Uri(pathListado);
            fInformeWeb.ShowDialog();
        }
```
</details>
