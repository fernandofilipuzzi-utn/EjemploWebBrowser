# Ejemplo de uso del control WebBrowser

## Ejemplo de ayuda web

<p>El ejemplo de prueba es el siguiente:</p>
<br/><img style="width:300px;" src="Ejemplo_webbrowser/EjemploAyuda/docs/pantallazo1.jpg"/>

<p>El documento de ayuda web se muestra así:</p>
<br/><img style="width:300px;" src="Ejemplo_webbrowser/EjemploAyuda/docs/pantallazo2.jpg"/>

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


## Ejemplos WebBrowser y WebView2

<div style="text-align:center">
<br/><img style="width:300px;" src="Ejemplo_webbrowser/WebBrowser/docs/pantallazo.jpg"/>
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

<p>Para el caso de usar el control WebView2:</p>

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
