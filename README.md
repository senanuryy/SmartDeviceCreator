# SmartDeviceCreator
The **SmartDeviceCreator** project is a console-based application designed to simulate the creation of smart devices, such as phones and computers. It demonstrates fundamental OOP (Object-Oriented Programming) principles, including:

- **Inheritance**
- **Polymorphism**
- **Encapsulation**
- **Abstraction**

## Features
1. **Device Creation**:
   - Users can choose to create either a `Phone` or a `Computer`.
   - The program collects information about the selected device from the user.
2. **Encapsulation**:
   - The `Computer` class ensures the USB port count is restricted to either `2` or `4`. Invalid inputs are replaced with `-1`, and a warning message is displayed.
3. **Polymorphism**:
   - The `BaseMakine` class includes a virtual method `BilgileriYazdir()`, which is overridden by the `Phone` and `Computer` classes to include their specific details.
4. **Abstraction**:
   - An abstract method `UrunAdiGetir()` in the `BaseMakine` class is implemented by derived classes to display the product's name.
5. **Interactive Workflow**:
   - Users can repeatedly create new devices or exit the program based on their input.

## How It Works
### 1. User Selection
The program starts by asking the user to choose a device type:

- Enter `1` for a **Phone**.
- Enter `2` for a **Computer**.

### 2. Input Device Details
After selecting the device type, the program prompts the user to input details specific to the device:

#### Phone Details:
- Serial Number
- Name
- Description
- Operating System

#### Computer Details:
- Serial Number
- Name
- Description
- Operating System
- USB Port Count (must be `2` or `4`)

### 3. Display Device Information
Once all details are entered, the program:
- Displays the device's details using the `BilgileriYazdir()` method.
- Shows the product name using the `UrunAdiGetir()` method.

### 4. Repeat or Exit
After displaying the information, the program asks the user if they want to create another device:
- Enter `Evet` to create another device.
- Enter `Hayır` to exit the program.
- Invalid input results in program termination.
