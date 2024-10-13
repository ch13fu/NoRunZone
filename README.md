# NoRunZone

NoRunZone is a lightweight Windows tool to control the execution of `.exe` files within a selected folder. You can enable or disable the ability to run `.exe` files, providing extra security and control over specific directories.

## Features

- **Select a Folder:** Choose any folder to manage execution permissions.
- **Disable Execution:** Block `.exe` files from running in the selected folder.
- **Enable Execution:** Restore execution permissions for `.exe` files.

![NoRunZone Interface](https://github.com/ch13fu/NoRunZone/blob/main/main.png)

## Important

⚠️ **Run as Administrator:**  
This application modifies folder permissions. You must run it as an administrator for it to function correctly.

**Warning:** Avoid using this tool on system-critical folders as it may impact the stability of your system.

## How to Use

1. **Select a folder:** Click `Select Folder` to choose the folder where you want to manage file execution permissions.
2. **Disable Execution:** Click `DISABLE` to block `.exe` files from running.
3. **Enable Execution:** Click `ENABLE` to restore execution permissions for the files.

## Installation

1. Clone the repository:
    ```bash
    git clone https://github.com/ch13fu/NoRunZone.git
    ```
2. Open in Visual Studio and build the solution.

Alternatively, download the executable from the [Releases](https://github.com/ch13fu/NoRunZone/releases) page.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
