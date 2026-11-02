# App Hotel — Agenda 13

Projeto acadêmico em .NET MAUI (C# e XAML), baseado nos temas apresentados na Agenda 13:
- componentes de interface gráfica;
- BindingContext / data binding;
- Stepper;
- DatePicker;
- Picker;
- navegação e tela Sobre.

## Antes de entregar
1. Abra `AppHotel/AboutPage.xaml`.
2. Substitua `[SEU NOME]` pelo seu nome.
3. Confira se o ano `2026` está correto para sua entrega.

## Gerar o APK sem Visual Studio ou VS Code
Este repositório inclui GitHub Actions em `.github/workflows/build-android.yml`.

1. Crie um repositório no GitHub e envie todos os arquivos desta pasta.
2. No repositório, abra a aba **Actions**.
3. Se aparecer uma confirmação para habilitar workflows, confirme.
4. Aguarde o workflow **Build Android APK** terminar com sucesso.
5. Abra a execução concluída e baixe o artefato **AppHotel-APK**.
6. Extraia o ZIP baixado para obter o arquivo `.apk`.

A compilação é feita em um runner Windows na nuvem. Não precisa instalar IDE no computador.

## Executar e tirar os prints
1. Transfira o APK para um celular Android.
2. Abra o arquivo e permita a instalação do aplicativo se o Android solicitar.
3. Abra **App Hotel**.
4. Abra o menu de navegação e entre em **Sobre**.
5. Tire uma captura de tela da página Sobre (no Android, normalmente Power + Volume para baixo).
6. Coloque a captura original na pasta `prints/`.
7. Compacte a pasta `prints/` em um arquivo ZIP para enviar ao professor.

**Importante:** as capturas não estão pré-fabricadas neste pacote. Elas devem ser feitas com o aplicativo realmente executando no seu aparelho.

## Observação sobre o material
O PDF da Agenda 13 apresenta os conceitos e componentes, e aponta um repositório de referência. Ele não traz, nas páginas fornecidas, o código completo de cada tela nem imagens detalhadas de todo o layout. Este projeto implementa uma proposta própria de App Hotel usando os componentes e conceitos indicados, incluindo a tela Sobre solicitada.

## Estrutura
- `AppHotel/` — projeto .NET MAUI Android.
- `.github/workflows/` — compilação automática do APK.
- `prints/` — local para salvar suas capturas reais da tela Sobre.
