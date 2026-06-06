# Doge-block (3D Physics Puzzle Game)

A dynamic and fast-paced 3D physics-based puzzle/action game built using **Unity 6 (6000.0.41f1)**. The game challenges players with strategic positioning, physics-based block interactions, and responsive grid layouts, all packaged inside a stylized 3D environment.

---

## 🚀 Key Features

* **Unity 6 Engine Native:** Optimized using the latest performance enhancement pipelines and graphics handling features of Unity 6000.0.41f1.
* **3D Physics-Driven Mechanics:** Smooth handling of 3D physical materials, rigidbodies, and gravity-defying block interactions.
* **Algorithmic Board & Grid Operations:** Custom array data and computational logic to seamlessly handle cell tracking, block configurations, and clearance updates.
* **Production-Grade Infrastructure:** Configured with active asset tracking via Git LFS for binary asset stability and strict `.meta` file persistence.

---

## 📂 Project Architecture & Script Breakdown

The codebase splits responsibilities between core gameplay management, grid alignment, and dynamic asset handling inside the `Assets/` directory:

### ⚙️ Core Management & Grid Systems
* **`BlockController.cs` / Player Actions:** Handles inputs for moving, rotating, or launching blocks inside the 3D space with precise boundary constraints.
* **`GridSystem3D.cs`**: Automatically structures the game's arena matrix, validating cell availability and tracking filled rows or columns for core score loops.

### 🐕 Theme & Interaction Elements
* **`DogeElement.cs`**: Manages specialized physics interactions or point multipliers linked directly with theme-specific blocks.
---

## 🎮 Controls

* **Move Block:** Use `W`, `A`, `S`, `D` or the **Arrow Keys** to shift the block positions laterally across the 3D grid.

---

## 🛠️ Getting Started

### Prerequisites
* **Unity Hub & Editor:** Version **6000.0.41f1** or a compatible modern Unity 6 release.
* **Git Tools:** Git Large File Storage (**Git LFS**) installed globally.

### Installation & Setup

1. **Initialize Git LFS** on your system before cloning binary asset configurations:
   ```bash
   git lfs install
