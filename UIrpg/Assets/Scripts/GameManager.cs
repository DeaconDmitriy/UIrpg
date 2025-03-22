using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Enemy enemy;
    [SerializeField] private TMP_Text playerNameText, playerHealthText, enemyNameText, enemyHealthText;
    [SerializeField] private TMP_Text playerLevelText, playerXPText;
    [SerializeField] private GameObject[] enemyPrefabs;
    [SerializeField] private Transform enemySpawnPoint;
    [SerializeField] private GameObject weaponSelectionPanel;
    [SerializeField] private Weapon sword, spear, dagger;

    void Start()
    {
        weaponSelectionPanel.SetActive(true);
    }

    public void SelectSword()
    {
        AssignWeaponToPlayer(sword);
    }

    public void SelectSpear()
    {
        AssignWeaponToPlayer(spear);
    }

    public void SelectDagger()
    {
        AssignWeaponToPlayer(dagger);
    }

    private void AssignWeaponToPlayer(Weapon weapon)
    {
        player.SetWeapon(weapon);
        weaponSelectionPanel.SetActive(false);
        UpdateUI();
    }

    public void DoRound()
    {
        if (player.health <= 0)
        {
            Debug.Log("Game Over");
            return;
        }

        int playerDamage = player.Attack();
        enemy.GetHit(playerDamage);

        if (enemy.health <= 0)
        {
            player.AddXP(50);
            SpawnNewEnemy();
            return;
        }

        int enemyDamage = enemy.Attack();
        player.GetHit(enemyDamage);

        if (player.health <= 0)
        {
            Debug.Log("Game Over");
            return;
        }

        UpdateUI();
    }

    void SpawnNewEnemy()
    {
        if (enemy != null)
        {
            Destroy(enemy.gameObject);
        }

        int index = Random.Range(0, enemyPrefabs.Length);
        GameObject newEnemy = Instantiate(enemyPrefabs[index], enemySpawnPoint.position, Quaternion.identity);
        enemy = newEnemy.GetComponent<Enemy>();
        UpdateUI();
    }

    void UpdateUI()
    {
        playerNameText.text = player.CharName;
        playerHealthText.text = player.health.ToString();
        playerLevelText.text = "Level: " + player.Level;
        playerXPText.text = "XP: " + player.CurrentXP + "/" + player.XPToNextLevel;

        if (enemy != null)
        {
            enemyNameText.text = enemy.name;
            enemyHealthText.text = enemy.health.ToString();
        }
        else
        {
            enemyNameText.text = "-";
            enemyHealthText.text = "-";
        }
    }

    public void ToggleShield()
    {
        player.Shield.Toggle();
    }

    public void CastBuff()
    {
        player.CastBuff();

        int enemyDamage = enemy.Attack();
        player.GetHit(enemyDamage);

        if (player.health <= 0)
        {
            Debug.Log("Game Over");
            return;
        }

        UpdateUI();
    }

    public void CastHeal()
    {
        player.CastHeal();

        int enemyDamage = enemy.Attack();
        player.GetHit(enemyDamage);

        if (player.health <= 0)
        {
            Debug.Log("Game Over");
            return;
        }

        UpdateUI();
    }


}
