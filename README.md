---

# Konwersja systemów liczbowych (Rzymski ↔ Arabski)

Aplikacja napisana w **C# WPF** służąca do konwersji między liczbami rzymskimi a arabskimi.

Projekt został stworzony przez **Macieja Strzelca**.

---

## Opis

Aplikacja umożliwia:

* Konwersję **z liczby rzymskiej na arabską**.
* Konwersję **z liczby arabskiej na rzymską** (dla wartości od 1 do 3000).

Interfejs graficzny został wykonany w **WPF**, a konwersja odbywa się po kliknięciu odpowiedniego przycisku.

---

## Funkcjonalności

1. **Podaj liczbę rzymską → liczba arabska**

   * Wprowadź cyfrę rzymską w polu tekstowym.
   * Kliknij „Konwertuj”, aby uzyskać wynik w systemie arabskim.

2. **Podaj liczbę arabską → liczba rzymska**

   * Wprowadź liczbę arabską (1–3000).
   * Kliknij „Konwertuj”, aby uzyskać wynik w systemie rzymskim.

3. **Resetowanie pól**

   * Kliknięcie przycisku „Resetuj” czyści oba pola.

4. **Wybór trybu konwersji**

   * RadioButton umożliwia przełączenie między trybem Rzym → Arab i Arab → Rzym.

---

## Instrukcja użycia

1. Uruchom aplikację.
2. Wybierz rodzaj konwersji za pomocą RadioButton:

   * „Konwersja z liczby rzymskiej na arabską”
   * „Konwersja z liczby arabskiej na rzymską”
3. Wpisz odpowiednią wartość w polu tekstowym.
4. Kliknij przycisk **Konwertuj**.
5. Wynik pojawi się w dolnym polu.
6. Aby wyczyścić pola, kliknij **Resetuj**.

---

## Wymagania

* .NET Framework 4.7.2 lub wyższy
* Visual Studio 2019 lub nowsze (zalecane do uruchomienia projektu WPF)

---

## Przykłady użycia

| Tryb konwersji | Wejście | Wyjście   |
| -------------- | ------- | --------- |
| Rzym → Arab    | `XIV`   | `14`      |
| Arab → Rzym    | `1999`  | `MCMXCIX` |

---

## Uwagi

* W przypadku wprowadzenia niepoprawnych znaków w trybie konwersji na rzymskie wyświetlane jest okno ostrzeżenia.
* Aplikacja obsługuje tylko liczby arabskie od 1 do 3000 w konwersji na rzymskie.

---

## Autor

**Maciej Strzelec**
**Maj 2025**

---
