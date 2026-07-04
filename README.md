# Enrollment System 🎓🏫

A professional, feature-rich C# application designed to streamline student enrollment and institutional management. This desktop application provides an intuitive dashboard for administrators to monitor school metrics, track student and teacher records, and manage billing statements efficiently.

---

## 📋 Overview

The **Enrollment System** transforms how educational centers handle student registration, data tracking, and everyday administrative overhead. Built with a clean UI, it centralizes core academic workflows, eliminating traditional paper logs. The primary dashboard provides clear analytics at a glance—highlighting currently enrolled students, total faculty counts, and historical graduation figures alongside a live student status grid.

---

## ✨ Key Features

*   **Executive Dashboard Metrics:** Real-time counter cards that track vital statistics including **Enrolled Students**, **Total Teachers**, and **Graduated Students**.
*   **Comprehensive Student Registry:** A dedicated overview tracking essential data fields (`student_id`, `student_name`, `student_grade`, `student_status`, and `date_insert`).
*   **Faculty & Staff Directory:** Specialized data management section to log, update, and manage teacher information.
*   **Billing & Statement Tracking:** Integrated financial tracking tools designed to monitor payments, balances, and tuition logs.
*   **Institutional Configuration ("School"):** Dedicated settings or panel to adjust school terms, academic years, or grade boundaries.
*   **Role-Based Security:** Features an explicit "Welcome, admin" session authentication layer and a secure logout mechanism to safeguard data confidentiality.
*   **Standard Desktop Windows UI:** A clean, organized, light-blue accent theme designed for long-term data entry comfort and professional usability.

---

## 📸 Preview

Below is a snapshot of the active administrator control panel showcasing the layout of the metrics cards and the student tracking ledger.

---

## 🚀 Getting Started

### Prerequisites

*   A Windows PC (Windows 10 or Windows 11 recommended).
*   **Microsoft .NET Runtime:** Ensure you have the corresponding .NET Framework or .NET Desktop Runtime installed (e.g., .NET 6.0/8.0 Desktop Runtime or newer, depending on the compilation). You can download it [from the Microsoft website](https://dotnet.microsoft.com/download/dotnet).
*   **Database Component:** A local or remote database instance (such as SQL Server or MySQL) configured to connect with the application's configuration file.

### 🛠️ Installation & Usage

1.  **Download the latest version:** Clone this repository or download the source files.
    ```bash
    git clone [https://github.com/itsonlyrence/ENROLLMENT-SYSTEM.git](https://github.com/itsonlyrence/ENROLLMENT-SYSTEM.git)
    ```

2.  **Navigate to the installation folder:** Open the directory where you saved the files.

3.  **Run the Application:**
    *   *If running from code:* Open the solution (`.sln`) file in Visual Studio, configure your database connection string, and press `F5` to build and run.
    *   *If running a release:* Double-click the main executable file (e.g., `EnrollmentSystem.exe`).

---

## 🤝 Contributing

This project is open-source. Feel free to open an **Issue** for bug reports or feature requests, or submit a **Pull Request** with your own improvements to the data models, dashboard interface, or database backend.

---

## ✍️ Author

*   **itsonlyrence** - [GitHub Profile](https://github.com/itsonlyrence)

---

## 📄 License

This project is open-source and available under the [MIT License](LICENSE).
