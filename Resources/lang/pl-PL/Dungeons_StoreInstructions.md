# Część 1 - Skrypt PowerShell
Wersja Minecraft Dungeons ze sklepu Microsoft Store nie zezwala na modyfikowanie jej plików/folderów. Aby obejść tę blokadę, wykonaj następujące czynności:

## Wymagania wstępne:
- Tymczasowo wyłącz jakiekolwiek oprogramowanie antywirusowe. Większość z nich wykryje, że uruchomiony jest nieznany skrypt i spróbuje go zatrzymać.
- Jeśli używasz programu Bitdefender, należy go odinstalować przed kontynuowaniem, ponieważ przerywa on skrypt, nawet jeśli zostanie wyłączony.
- Upewnij się, że posiadasz co najmniej 10 GB wolnego miejsca.
- Upewnij się, że Twoja gra jest aktualna. Aby to zrobić, naciśnij klawisze Windows + R, wpisz `ms-windows-store://DownloadsAndUpdates/` i naciśnij Enter. Następnie naciśnij "Pobierz aktualizacje" w prawym górnym rogu nowo otwartego okna.
- Zainstaluj [Pakiet redystrybucyjny Visual C++](https://aka.ms/vs/16/release/vc_redist.x64.exe). Zrób to, nawet jeśli uważasz, że jest już zainstalowane. Możesz posiadać starszą wersję, która nie zadziała.

## W Bedrock Launcher:
1. Upewnij się, że Źródło gry jest ustawione na `Microsoft Store`
3. Click on `Install Store Patch`

## In the Powershell Window:

3. You will be asked to select a folder. Choose an empty folder where you want the game to be moved to. Do not choose a folder in Program Files or One Drive, it will break things.
4. The game will open at one point. Do not close it when this happens. If you run into any issues, make sure to check the Troubleshooting section below.
5. A `~mods` folder will appear. This is where you place your mods.
7. Launching the modded game is just like launching the regular game. You can do it from the start menu, Windows Store, Xbox app, and so on, just like you normally do. Do NOT try to launch it by running the .exe files in the game folder.

## Troubleshooting:
- If you run into any issues while/after patching the game, some of these things might help you.
- If the game didn't open at all while patching and the patching didn't work, try opening the game manually before running the patcher. Keep the game open until it either closes by itself or the patcher finishes.
- If you get an error saying it can't verify your ownership of the game, you must have launched the game using the .exe file. Don't do that. Run the game from the start menu, Windows Store, or Xbox app. If you did, but still get this error, reinstall the regular game and log in at least once (open the game and select a character) before patching it.

# Part 2 - The Bedrock Launcher Setup
1. Set the install location to the folder containing `Dungeons.exe`. It should be in a parent folder of the `~mods` folder from earlier
2. Select where you want your symbolic mods folder to be (it should not be in the same location as `~mods` folder from earlier)
3. Click on `Install Symbolic Link`
4. Your game's mod folder should now be paired with your symbolic mods folder

# How to Update
1. Click on `Uninstall Symbolic Link`
2. Click on `Update Store Patch`
3. Repeat Steps 3 through 6 of Part 1 if nessisary
4. Repeat Steps 1 through 4 of Part 2
5. Gotowe



