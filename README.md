# ⏳ Auto Close Timer Pro

A sleek, lightweight, and modern Windows desktop application designed to schedule system shutdowns, restarts, and sleep states with precision.

Originally built as a classic legacy Windows batch script, now reimagined into a modern, native **.NET 9 WPF** desktop application featuring a comfortable dark UI and live countdown tracking.

---

## ✨ Features

- **🌙 Modern Dark UI:** Spaciously padded, eye-friendly, and minimal interface designed for late-night use.
- **⏱️ Live Digital Countdown:** Real-time digital clock displays the exact time remaining down to the second.
- **⚡ System Actions:**
  - **Shutdown:** Safely turns off your PC.
  - **Restart:** Reboots your system after the specified duration.
  - **Sleep:** Puts your machine into low-power sleep mode.
- **⚡ Quick Pre-set Buttons:** One-click presets (+15m, +30m, +1h, +2h) for quick scheduling.
- **🪶 Ultra Lightweight:** Extremely small executable size (~250 KB) without bloated dependencies.
- **🛡️ Auto-Runtime Detection:** If the target PC lacks the required .NET runtime, Windows will automatically prompt and direct the user to install the official Microsoft Desktop Runtime in seconds.

---

## 📸 Preview

<p align="center">
  <img width="439" alt="Auto Close Timer Preview" src="https://github.com/user-attachments/assets/8e32a3f4-7760-4f43-b08f-c7f428f4ce68" />
</p>

---

## 🚀 Getting Started

### Prerequisites
- **OS:** Windows 10 / Windows 11 (64-bit)
- **Runtime:** [.NET Desktop Runtime 9.0 (x64)](https://dotnet.microsoft.com/download/dotnet/9.0) *(If missing, Windows prompts you to install it automatically upon first launch).*

### Download & Run
1. Head over to the [Releases](https://github.com/JHEXLEX/Simple-Auto-Shutdown-PC/releases) page.
2. Download the latest `AutoCloseTimer.exe`.
3. Double-click to launch — no installation required!

---

## 🛠️ Build from Source

If you want to build or inspect the source code using **JetBrains Rider**, **Visual Studio**, or the **.NET CLI**:

**Step 1: Clone the repository**
```bash
git clone https://github.com/JHEXLEX/Simple-Auto-Shutdown-PC.git
cd Simple-Auto-Shutdown-PC/AutoCloseTimer
```

**Step 2: Publish the single-file executable**
```bash
dotnet publish -c Release -o "./publish"
```

The output `.exe` will be located inside the `publish` directory.

---

## 🌐 Connect With Me

- **LinkedIn:** [Ömer Genç](https://www.linkedin.com/in/%C3%B6mer-gen%C3%A7/)
- **Instagram:** [@hayyam.iniko](https://www.instagram.com/hayyam.iniko/)
- **Kick:** [hayyam-iniko](https://kick.com/hayyam-iniko)
- **GitHub:** [@JHEXLEX](https://github.com/JHEXLEX)

---

## 📜 License & Acknowledgments

This project is licensed under the **MIT License** - see the [LICENSE](LICENSE) file for details.

> **Note:**  
> *✦ AI Assisted Architecture • Designed and refactored with the assistance of Google Gemini.*
