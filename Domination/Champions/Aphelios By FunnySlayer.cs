﻿using System;
using System.Linq;
using SharpDX;
using System.Collections.Generic;
using EnsoulSharp;
using EnsoulSharp.SDK;
using EnsoulSharp.SDK.Events;
using EnsoulSharp.SDK.MenuUI;
using EnsoulSharp.SDK.MenuUI.Values;
using EnsoulSharp.SDK.Prediction;
using EnsoulSharp.SDK.Utility;
using FunnySlayerCommon;

namespace DominationAIO.Champions.Aphelios
{
    internal static class MenuSettings
    {
        public static MenuSeparator secsec = new MenuSeparator("secsec", "_____________________________________");
        public static MenuSeparator secsec1 = new MenuSeparator("secsec1", "_____________________________________");
        public static class OutAARange
        {
            public static MenuSlider Calibrum = new MenuSlider("OUT AA Range Calibrum", "Calibrum", 5, 0, 5);
            public static MenuSlider Severum = new MenuSlider("OUT AA Range Severum", "Severum", 3, 0, 5);
            public static MenuSlider Gravitum = new MenuSlider("OUT AA Range Gravitum", "Gravitum", 4, 0, 5);
            public static MenuSlider Infernum = new MenuSlider("OUT AA Range Infernum", "Infernum", 2, 0, 5);
            public static MenuSlider Crescendum = new MenuSlider("OUT AA Range Crescendum", "Crescendum", 1, 0, 5);
        }
        public static class Closer
        {
            public static MenuSlider Calibrum = new MenuSlider("Closer Calibrum", "Calibrum", 1, 0, 5);
            public static MenuSlider Severum = new MenuSlider("Closer Severum", "Severum", 3, 0, 5);
            public static MenuSlider Gravitum = new MenuSlider("Closer Gravitum", "Gravitum", 4, 0, 5);
            public static MenuSlider Infernum = new MenuSlider("Closer Infernum", "Infernum", 2, 0, 5);
            public static MenuSlider Crescendum = new MenuSlider("Closer Crescendum", "Crescendum", 5, 0, 5);
        }
        public static class LowHp
        {
            public static MenuSlider Calibrum = new MenuSlider("LowHp Calibrum", "Calibrum", 1, 0, 5);
            public static MenuSlider Severum = new MenuSlider("LowHp Severum", "Severum", 5, 0, 5);
            public static MenuSlider Gravitum = new MenuSlider("LowHp Gravitum", "Gravitum", 4, 0, 5);
            public static MenuSlider Infernum = new MenuSlider("LowHp Infernum", "Infernum", 2, 0, 5);
            public static MenuSlider Crescendum = new MenuSlider("LowHp Crescendum", "Crescendum", 3, 0, 5);
        }
        public static class RGun
        {
            public static MenuSlider Calibrum = new MenuSlider("RGun Calibrum", "Calibrum", 1, 0, 5);
            public static MenuSlider Severum = new MenuSlider("RGun Severum", "Severum", 5, 0, 5);
            public static MenuSlider Gravitum = new MenuSlider("RGun Gravitum", "Gravitum", 4, 0, 5);
            public static MenuSlider Infernum = new MenuSlider("RGun Infernum", "Infernum", 2, 0, 5);
            public static MenuSlider Crescendum = new MenuSlider("RGun Crescendum", "Crescendum", 3, 0, 5);
        }
        public static class SelectedGun
        {
            public static MenuSlider Calibrum = new MenuSlider("LowHp Calibrum", "Calibrum", 2, 0, 5);
            public static MenuSlider Severum = new MenuSlider("LowHp Severum", "Severum", 1, 0, 5);
            public static MenuSlider Gravitum = new MenuSlider("LowHp Gravitum", "Gravitum", 3, 0, 5);
            public static MenuSlider Infernum = new MenuSlider("LowHp Infernum", "Infernum", 5, 0, 5);
            public static MenuSlider Crescendum = new MenuSlider("LowHp Crescendum", "Crescendum", 4, 0, 5);
        }

        public static class Combo
        {
            public static MenuBool QCombo = new MenuBool("Q.Combo", "Q.Combo");
            public static MenuBool WCombo = new MenuBool("W.Combo", "W.Combo");
            public static MenuBool RCombo = new MenuBool("R.Combo", "R.Combo");
        }

        public static void AddApheliosMenu(this Menu menu)
        {
            if (menu == null)
                return;

            var getgun = new Menu("get_aphelios_best_gun", "Get Best Gun");
            //Out AA Range
            var GunOutAARange = new Menu("Best Gun Out AA Range", "Out Of AA Range");
            GunOutAARange.Add(secsec);
            GunOutAARange.Add(OutAARange.Calibrum);
            GunOutAARange.Add(OutAARange.Severum);
            GunOutAARange.Add(OutAARange.Gravitum);
            GunOutAARange.Add(OutAARange.Infernum);
            GunOutAARange.Add(OutAARange.Crescendum);
            GunOutAARange.Add(secsec1);
            //Closer
            var GunCloser = new Menu("Best Gun Closer", "Closer");
            GunCloser.Add(secsec);
            GunCloser.Add(Closer.Calibrum);
            GunCloser.Add(Closer.Severum);
            GunCloser.Add(Closer.Gravitum);
            GunCloser.Add(Closer.Infernum);
            GunCloser.Add(Closer.Crescendum);
            GunCloser.Add(secsec1);
            //LowHp
            var GunLowHp = new Menu("Best Gun Low Hp", "Low Hp");
            GunLowHp.Add(secsec);
            GunLowHp.Add(LowHp.Calibrum);
            GunLowHp.Add(LowHp.Severum);
            GunLowHp.Add(LowHp.Gravitum);
            GunLowHp.Add(LowHp.Infernum);
            GunLowHp.Add(LowHp.Crescendum);
            GunLowHp.Add(secsec1);
            //R Gun
            var GunR = new Menu("Best Gun R Gun", "R Gun");
            GunR.Add(secsec);
            GunR.Add(RGun.Calibrum);
            GunR.Add(RGun.Severum);
            GunR.Add(RGun.Gravitum);
            GunR.Add(RGun.Infernum);
            GunR.Add(RGun.Crescendum);
            GunR.Add(secsec1);
            //Selected
            var GunSelected = new Menu("Best Gun Selected", "Selected");
            GunSelected.Add(secsec);
            GunSelected.Add(SelectedGun.Calibrum);
            GunSelected.Add(SelectedGun.Severum);
            GunSelected.Add(SelectedGun.Gravitum);
            GunSelected.Add(SelectedGun.Infernum);
            GunSelected.Add(SelectedGun.Crescendum);
            GunSelected.Add(secsec1);

            getgun.Add(GunOutAARange);
            getgun.Add(GunCloser);
            getgun.Add(GunLowHp);
            getgun.Add(GunR);
            getgun.Add(GunSelected);
            var helper = new Menu("Get Helper", "Get Helper");
            helper.AddTargetSelectorMenu();
            SPredictionMash.ConfigMenu.Initialize(helper, "Get Help pls");
            new SebbyLibPorted.Orbwalking.Orbwalker(helper);
            menu.Add(helper);
            menu.Add(getgun);
            menu.Add(secsec);
            menu.Add(Combo.QCombo);
            menu.Add(Combo.WCombo);
            menu.Add(Combo.RCombo);
            menu.Add(secsec1);

            Game.OnUpdate += WQ;
            Game.OnUpdate += WOutAARange;
            Game.OnUpdate += WLowHp;
            Game.OnUpdate += WCloser;
            Game.OnUpdate += Game_OnUpdate;
            Orbwalker.OnAction += Orbwalker_OnAction;
            Game.OnUpdate += GetChecker;
            Game.OnUpdate += QCombo;
        }

        private static void Game_OnUpdate(EventArgs args)
        {
            if (!Combo.WCombo.Enabled)
                return;
            if (ObjectManager.Player.IsDead || OnAA || BeforeAA)
                return;

            if (!loaded.W.IsReady() || TargetSelector.GetTarget(loaded.W.Range) == null)
            {
                return;
            }

            if (Orbwalker.ActiveMode > OrbwalkerMode.Harass)
                return;

            if (OutOfAARangeOfGun || CloseOfAARangeOfGun || LowhpOfGun)
                return;

            var target = FSTargetSelector.GetFSTarget(ObjectManager.Player.HasBuff(loaded.CalibrumOn) ? ObjectManager.Player.GetRealAutoAttackRange() - 100 : ObjectManager.Player.GetRealAutoAttackRange());

            if (target != null && ObjectManager.Player.HealthPercent >= 40 && target.DistanceToPlayer() > (ObjectManager.Player.HasBuff(loaded.CalibrumOn) ? ObjectManager.Player.GetRealAutoAttackRange() - 100 : ObjectManager.Player.GetRealAutoAttackRange()) / 1.5f)
            {
                if (ObjectManager.Player.HasBuff(loaded.CalibrumOff))
                {
                    var Value = SelectedGun.Calibrum.Value;
                    if (ObjectManager.Player.HasBuff(loaded.CalibrumOn))
                    {
                        if (Value > SelectedGun.Calibrum.Value)
                        {
                            if (loaded.W.Cast())
                                return;
                        }
                    }
                    if (ObjectManager.Player.HasBuff(loaded.SeverumOn))
                    {
                        if (Value > SelectedGun.Severum.Value)
                        {
                            if (loaded.W.Cast())
                                return;
                        }
                    }
                    if (ObjectManager.Player.HasBuff(loaded.GravitumOn))
                    {
                        if (Value > SelectedGun.Gravitum.Value)
                        {
                            if (loaded.W.Cast())
                                return;
                        }
                    }
                    if (ObjectManager.Player.HasBuff(loaded.InfernumOn))
                    {
                        if (Value > SelectedGun.Infernum.Value)
                        {
                            if (loaded.W.Cast())
                                return;
                        }
                    }
                    if (ObjectManager.Player.HasBuff(loaded.CrescendumOn))
                    {
                        if (Value > SelectedGun.Crescendum.Value)
                        {
                            if (loaded.W.Cast())
                                return;
                        }
                    }
                }
                if (ObjectManager.Player.HasBuff(loaded.SeverumOff))
                {
                    var Value = SelectedGun.Severum.Value;
                    if (ObjectManager.Player.HasBuff(loaded.CalibrumOn))
                    {
                        if (Value > SelectedGun.Calibrum.Value)
                        {
                            if (loaded.W.Cast())
                                return;
                        }
                    }
                    if (ObjectManager.Player.HasBuff(loaded.SeverumOn))
                    {
                        if (Value > SelectedGun.Severum.Value)
                        {
                            if (loaded.W.Cast())
                                return;
                        }
                    }
                    if (ObjectManager.Player.HasBuff(loaded.GravitumOn))
                    {
                        if (Value > SelectedGun.Gravitum.Value)
                        {
                            if (loaded.W.Cast())
                                return;
                        }
                    }
                    if (ObjectManager.Player.HasBuff(loaded.InfernumOn))
                    {
                        if (Value > SelectedGun.Infernum.Value)
                        {
                            if (loaded.W.Cast())
                                return;
                        }
                    }
                    if (ObjectManager.Player.HasBuff(loaded.CrescendumOn))
                    {
                        if (Value > SelectedGun.Crescendum.Value)
                        {
                            if (loaded.W.Cast())
                                return;
                        }
                    }
                }
                if (ObjectManager.Player.HasBuff(loaded.GravitumOff))
                {
                    var Value = SelectedGun.Gravitum.Value;
                    if (ObjectManager.Player.HasBuff(loaded.CalibrumOn))
                    {
                        if (Value > SelectedGun.Calibrum.Value)
                        {
                            if (loaded.W.Cast())
                                return;
                        }
                    }
                    if (ObjectManager.Player.HasBuff(loaded.SeverumOn))
                    {
                        if (Value > SelectedGun.Severum.Value)
                        {
                            if (loaded.W.Cast())
                                return;
                        }
                    }
                    if (ObjectManager.Player.HasBuff(loaded.GravitumOn))
                    {
                        if (Value > SelectedGun.Gravitum.Value)
                        {
                            if (loaded.W.Cast())
                                return;
                        }
                    }
                    if (ObjectManager.Player.HasBuff(loaded.InfernumOn))
                    {
                        if (Value > SelectedGun.Infernum.Value)
                        {
                            if (loaded.W.Cast())
                                return;
                        }
                    }
                    if (ObjectManager.Player.HasBuff(loaded.CrescendumOn))
                    {
                        if (Value > SelectedGun.Crescendum.Value)
                        {
                            if (loaded.W.Cast())
                                return;
                        }
                    }
                }
                if (ObjectManager.Player.HasBuff(loaded.InfernumOff))
                {
                    var Value = SelectedGun.Infernum.Value;
                    if (ObjectManager.Player.HasBuff(loaded.CalibrumOn))
                    {
                        if (Value > SelectedGun.Calibrum.Value)
                        {
                            if (loaded.W.Cast())
                                return;
                        }
                    }
                    if (ObjectManager.Player.HasBuff(loaded.SeverumOn))
                    {
                        if (Value > SelectedGun.Severum.Value)
                        {
                            if (loaded.W.Cast())
                                return;
                        }
                    }
                    if (ObjectManager.Player.HasBuff(loaded.GravitumOn))
                    {
                        if (Value > SelectedGun.Gravitum.Value)
                        {
                            if (loaded.W.Cast())
                                return;
                        }
                    }
                    if (ObjectManager.Player.HasBuff(loaded.InfernumOn))
                    {
                        if (Value > SelectedGun.Infernum.Value)
                        {
                            if (loaded.W.Cast())
                                return;
                        }
                    }
                    if (ObjectManager.Player.HasBuff(loaded.CrescendumOn))
                    {
                        if (Value > SelectedGun.Crescendum.Value)
                        {
                            if (loaded.W.Cast())
                                return;
                        }
                    }
                }
                if (ObjectManager.Player.HasBuff(loaded.CrescendumOff))
                {
                    var Value = SelectedGun.Crescendum.Value;
                    if (ObjectManager.Player.HasBuff(loaded.CalibrumOn))
                    {
                        if (Value > SelectedGun.Calibrum.Value)
                        {
                            if (loaded.W.Cast())
                                return;
                        }
                    }
                    if (ObjectManager.Player.HasBuff(loaded.SeverumOn))
                    {
                        if (Value > SelectedGun.Severum.Value)
                        {
                            if (loaded.W.Cast())
                                return;
                        }
                    }
                    if (ObjectManager.Player.HasBuff(loaded.GravitumOn))
                    {
                        if (Value > SelectedGun.Gravitum.Value)
                        {
                            if (loaded.W.Cast())
                                return;
                        }
                    }
                    if (ObjectManager.Player.HasBuff(loaded.InfernumOn))
                    {
                        if (Value > SelectedGun.Infernum.Value)
                        {
                            if (loaded.W.Cast())
                                return;
                        }
                    }
                    if (ObjectManager.Player.HasBuff(loaded.CrescendumOn))
                    {
                        if (Value > SelectedGun.Crescendum.Value)
                        {
                            if (loaded.W.Cast())
                                return;
                        }
                    }
                }
                SelectedOfGun = true;
            }
            else
            {
                SelectedOfGun = false;
            }          
        }

        private static void QCombo(EventArgs args)
        {
            if (!Combo.QCombo.Enabled)
                return;
            if (Orbwalker.ActiveMode > OrbwalkerMode.Harass)
                return;

            if (ObjectManager.Player.IsDead)
                return;

            var target = FSTargetSelector.GetFSTarget(loaded.Q1.Range);
            if (target == null)
            {
                return;
            }

            if (ObjectManager.Player.HasBuff(loaded.CalibrumOn) && loaded.Q1.IsReady())
            {
                var temptargets = GameObjects.EnemyHeroes.Where(i => !i.IsDead && i.IsValidTarget(loaded.Q1.Range) && SebbyLibPorted.Prediction.Prediction.GetPrediction(loaded.Q1, i).Hitchance >= SebbyLibPorted.Prediction.HitChance.High).OrderBy(i => i.Health);
                if(temptargets != null)
                {
                    foreach(var temp in temptargets)
                    {
                        if(temp != null)
                        {
                            var pred = SebbyLibPorted.Prediction.Prediction.GetPrediction(loaded.Q1, temp);
                            if(pred.Hitchance >= SebbyLibPorted.Prediction.HitChance.High)
                            {
                                if (loaded.Q1.Cast(pred.CastPosition))
                                    return;
                            }
                        }
                    }
                }
            }
            if (ObjectManager.Player.HasBuff(loaded.SeverumOn) && loaded.Q2.IsReady())
            {
                var targets = TargetSelector.GetTarget(550f);
                if (targets != null)
                    if (loaded.Q2.Cast())
                        return;
            }
            if (ObjectManager.Player.HasBuff(loaded.GravitumOn) && loaded.Q3.IsReady())
            {
                var targets = TargetSelector.GetTargets(loaded.Q3.Range);
                if (targets != null && targets.Any(i => i.HasBuff(loaded.GravitumDebuff)))
                    if (loaded.Q3.Cast())
                        return;
            }
            if (ObjectManager.Player.HasBuff(loaded.InfernumOn) && loaded.Q4.IsReady())
            {
                var temptargets = GameObjects.EnemyHeroes.Where(i => !i.IsDead && i.IsValidTarget(loaded.Q4.Range) && SebbyLibPorted.Prediction.Prediction.GetPrediction(loaded.Q1, i).Hitchance >= SebbyLibPorted.Prediction.HitChance.High).OrderBy(i => i.Health);
                if (temptargets != null)
                {
                    foreach (var temp in temptargets)
                    {
                        if (temp != null)
                        {
                            var pred = SebbyLibPorted.Prediction.Prediction.GetPrediction(loaded.Q4, temp);
                            if (pred.Hitchance >= SebbyLibPorted.Prediction.HitChance.High)
                            {
                                if (loaded.Q4.Cast(pred.CastPosition))
                                    return;
                            }
                        }
                    }
                }
            }
            if (ObjectManager.Player.HasBuff(loaded.CrescendumOn) && loaded.Q5.IsReady())
            {
                var temptargets = GameObjects.EnemyHeroes.Where(i => !i.IsDead && i.IsValidTarget(600) && SebbyLibPorted.Prediction.Prediction.GetPrediction(loaded.Q1, i).Hitchance >= SebbyLibPorted.Prediction.HitChance.High).OrderBy(i => i.Health);
                if (temptargets != null)
                {
                    foreach (var temp in temptargets)
                    {
                        if (temp != null)
                        {
                            var pred = SebbyLibPorted.Prediction.Prediction.GetPrediction(loaded.Q5, temp);
                            if (pred.Hitchance >= SebbyLibPorted.Prediction.HitChance.High)
                            {
                                if (loaded.Q5.Cast(pred.CastPosition))
                                    return;
                            }
                        }
                    }
                }
            }
        }

        private static void WCloser(EventArgs args)
        {
            if (!Combo.WCombo.Enabled)
                return;
            if (ObjectManager.Player.IsDead || OnAA || BeforeAA)
                return;

            if (!loaded.W.IsReady() || TargetSelector.GetTarget(loaded.W.Range) == null)
            {
                return;
            }

            if (Orbwalker.ActiveMode > OrbwalkerMode.Harass)
                return;

            var target = FSTargetSelector.GetFSTarget(ObjectManager.Player.HasBuff(loaded.CalibrumOn) ? ObjectManager.Player.GetRealAutoAttackRange() - 100 : ObjectManager.Player.GetRealAutoAttackRange());
            if (target == null)
            {
                return;
            }

            if(ObjectManager.Player.HealthPercent >= 40 && target.IsValidTarget((ObjectManager.Player.HasBuff(loaded.CalibrumOn) ? ObjectManager.Player.GetRealAutoAttackRange() - 100 : ObjectManager.Player.GetRealAutoAttackRange()) / 1.5f) && !LowhpOfGun && !SelectedOfGun && !OutOfAARangeOfGun)
            {
                CloseOfAARangeOfGun = true;
                //Calibrum
                if (ObjectManager.Player.HasBuff(loaded.CalibrumOff))
                {
                    if (ObjectManager.Player.HasBuff(loaded.SeverumOn) && W2)
                    {
                        if (Closer.Calibrum.Value > Closer.Severum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.GravitumOn) && W3)
                    {
                        if (Closer.Calibrum.Value > Closer.Gravitum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.InfernumOn) && W4)
                    {
                        if (Closer.Calibrum.Value > Closer.Infernum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.CrescendumOn) && W5)
                    {
                        if (Closer.Calibrum.Value > Closer.Crescendum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                }
                //Severum
                if (ObjectManager.Player.HasBuff(loaded.SeverumOff))
                {
                    if (ObjectManager.Player.HasBuff(loaded.CalibrumOn) && W1)
                    {
                        if (Closer.Severum.Value > Closer.Calibrum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.GravitumOn) && W3)
                    {
                        if (Closer.Severum.Value > Closer.Gravitum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.InfernumOn) && W4)
                    {
                        if (Closer.Severum.Value > Closer.Infernum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.CrescendumOn) && W5)
                    {
                        if (Closer.Severum.Value > Closer.Crescendum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                }
                //Gravitum
                if (ObjectManager.Player.HasBuff(loaded.GravitumOff))
                {
                    if (ObjectManager.Player.HasBuff(loaded.SeverumOn) && W2)
                    {
                        if (Closer.Gravitum.Value > Closer.Severum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.CalibrumOn) && W1)
                    {
                        if (Closer.Gravitum.Value > Closer.Calibrum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.InfernumOn) && W4)
                    {
                        if (Closer.Gravitum.Value > Closer.Infernum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.CrescendumOn) && W5)
                    {
                        if (Closer.Gravitum.Value > Closer.Crescendum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                }
                //Infernum
                if (ObjectManager.Player.HasBuff(loaded.InfernumOff))
                {
                    if (ObjectManager.Player.HasBuff(loaded.SeverumOn) && W2)
                    {
                        if (Closer.Infernum.Value > Closer.Severum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.GravitumOn) && W3)
                    {
                        if (Closer.Infernum.Value > Closer.Gravitum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.CalibrumOn) && W1)
                    {
                        if (Closer.Infernum.Value > Closer.Calibrum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.CrescendumOn) && W5)
                    {
                        if (Closer.Infernum.Value > Closer.Crescendum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                }
                //Crescendum
                if (ObjectManager.Player.HasBuff(loaded.CrescendumOff))
                {
                    if (ObjectManager.Player.HasBuff(loaded.SeverumOn) && W2)
                    {
                        if (Closer.Crescendum.Value > Closer.Severum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.GravitumOn) && W3)
                    {
                        if (Closer.Crescendum.Value > Closer.Gravitum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.InfernumOn) && W4)
                    {
                        if (Closer.Crescendum.Value > Closer.Infernum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.CalibrumOn) && W1)
                    {
                        if (Closer.Crescendum.Value > Closer.Calibrum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                }

            }
            else
            {
                CloseOfAARangeOfGun = false;
            }
        }

        private static bool OutOfAARangeOfGun = false;
        private static bool CloseOfAARangeOfGun = false;
        private static bool LowhpOfGun = false;
        private static bool SelectedOfGun = false;  

        private static void WLowHp(EventArgs args)
        {
            if (!Combo.WCombo.Enabled)
                return;
            if (ObjectManager.Player.IsDead || OnAA || BeforeAA)
                return;

            if (!loaded.W.IsReady() || TargetSelector.GetTarget(loaded.W.Range) == null)
            {
                return;
            }

            if (Orbwalker.ActiveMode > OrbwalkerMode.Harass)
                return;

            var target = FSTargetSelector.GetFSTarget(ObjectManager.Player.HasBuff(loaded.CalibrumOn) ? ObjectManager.Player.GetRealAutoAttackRange() - 100 : ObjectManager.Player.GetRealAutoAttackRange());
            if (target == null)
            {
                return;
            }

            if(ObjectManager.Player.HealthPercent < 40 && target.InAutoAttackRange() && !SelectedOfGun && !CloseOfAARangeOfGun && !OutOfAARangeOfGun)
            {
                LowhpOfGun = true;
                //Calibrum
                if (ObjectManager.Player.HasBuff(loaded.CalibrumOff))
                {
                    if (ObjectManager.Player.HasBuff(loaded.SeverumOn) && W2)
                    {
                        if (LowHp.Calibrum.Value > LowHp.Severum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.GravitumOn) && W3)
                    {
                        if (LowHp.Calibrum.Value > LowHp.Gravitum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.InfernumOn) && W4)
                    {
                        if (LowHp.Calibrum.Value > LowHp.Infernum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.CrescendumOn) && W5)
                    {
                        if (LowHp.Calibrum.Value > LowHp.Crescendum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                }
                //Severum
                if (ObjectManager.Player.HasBuff(loaded.SeverumOff))
                {
                    if (ObjectManager.Player.HasBuff(loaded.CalibrumOn) && W1)
                    {
                        if (LowHp.Severum.Value > LowHp.Calibrum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.GravitumOn) && W3)
                    {
                        if (LowHp.Severum.Value > LowHp.Gravitum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.InfernumOn) && W4)
                    {
                        if (LowHp.Severum.Value > LowHp.Infernum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.CrescendumOn) && W5)
                    {
                        if (LowHp.Severum.Value > LowHp.Crescendum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                }
                //Gravitum
                if (ObjectManager.Player.HasBuff(loaded.GravitumOff))
                {
                    if (ObjectManager.Player.HasBuff(loaded.SeverumOn) && W2)
                    {
                        if (LowHp.Gravitum.Value > LowHp.Severum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.CalibrumOn) && W1)
                    {
                        if (LowHp.Gravitum.Value > LowHp.Calibrum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.InfernumOn) && W4)
                    {
                        if (LowHp.Gravitum.Value > LowHp.Infernum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.CrescendumOn) && W5)
                    {
                        if (LowHp.Gravitum.Value > LowHp.Crescendum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                }
                //Infernum
                if (ObjectManager.Player.HasBuff(loaded.InfernumOff))
                {
                    if (ObjectManager.Player.HasBuff(loaded.SeverumOn) && W2)
                    {
                        if (LowHp.Infernum.Value > LowHp.Severum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.GravitumOn) && W3)
                    {
                        if (LowHp.Infernum.Value > LowHp.Gravitum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.CalibrumOn) && W1)
                    {
                        if (LowHp.Infernum.Value > LowHp.Calibrum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.CrescendumOn) && W5)
                    {
                        if (LowHp.Infernum.Value > LowHp.Crescendum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                }
                //Crescendum
                if (ObjectManager.Player.HasBuff(loaded.CrescendumOff))
                {
                    if (ObjectManager.Player.HasBuff(loaded.SeverumOn) && W2)
                    {
                        if (LowHp.Crescendum.Value > LowHp.Severum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.GravitumOn) && W3)
                    {
                        if (LowHp.Crescendum.Value > LowHp.Gravitum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.InfernumOn) && W4)
                    {
                        if (LowHp.Crescendum.Value > LowHp.Infernum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.CalibrumOn) && W1)
                    {
                        if (LowHp.Crescendum.Value > LowHp.Calibrum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                }
            }
            else
            {
                LowhpOfGun = false; 
            }
        }

        private static bool W1 = true;
        private static bool W2 = true;
        private static bool W3 = true;
        private static bool W4 = true;
        private static bool W5 = true;
        private static void GetChecker(EventArgs args)
        {
            var target = GameObjects.EnemyHeroes.Where(i => i != null && !i.IsDead && i.IsValidTarget(float.MaxValue));
            if(target != null)
            {
                if (ObjectManager.Player.HasBuff(loaded.CalibrumOn))
                {
                    if (!target.Any(i => i.IsValidTarget(loaded.Q1.Range) && SebbyLibPorted.Prediction.Prediction.GetPrediction(loaded.Q1, i).Hitchance >= SebbyLibPorted.Prediction.HitChance.High) && loaded.Q2.IsReady())
                    {
                        W1 = false;
                    }else
                        W1 = true;
                }
                if (ObjectManager.Player.HasBuff(loaded.SeverumOn))
                {
                    if (!target.Any(i => i.IsValidTarget(loaded.Q2.Range)) && loaded.Q2.IsReady())
                    {
                        W2 = false;
                    }
                    else
                        W2 = true;
                }
                if (ObjectManager.Player.HasBuff(loaded.GravitumOn))
                {
                    if (!target.Any(i => i.IsValidTarget(loaded.Q3.Range) && i.HasBuff(loaded.GravitumDebuff)) && loaded.Q3.IsReady())
                    {
                        W3 = false;
                    }
                    else
                        W3 = true;
                }
                if (ObjectManager.Player.HasBuff(loaded.InfernumOn))
                {
                    if (!target.Any(i => i.IsValidTarget(loaded.Q4.Range)) && loaded.Q4.IsReady())
                    {
                        W4 = false;
                    }
                    else
                        W4 = true;
                }
                if (ObjectManager.Player.HasBuff(loaded.CrescendumOn))
                {
                    if (!target.Any(i => i.IsValidTarget(loaded.Q5.Range + 200)) && loaded.Q5.IsReady())
                    {
                        W5 = false;
                    }
                    else
                        W5 = true;
                }
            }          
        }

        private static void WOutAARange(EventArgs args)
        {
            if (!Combo.WCombo.Enabled)
                return;
            if (ObjectManager.Player.IsDead || OnAA || BeforeAA)
                return;

            if (!loaded.W.IsReady() || TargetSelector.GetTarget(loaded.W.Range) == null)
            {
                return;
            }

            if (Orbwalker.ActiveMode > OrbwalkerMode.Harass)
                return;

            var target = FSTargetSelector.GetFSTarget(ObjectManager.Player.GetRealAutoAttackRange() + 600);
            if(target == null)
            {
                return;
            }

            if ((target.DistanceToPlayer() > (ObjectManager.Player.HasBuff(loaded.CalibrumOn) ? ObjectManager.Player.GetRealAutoAttackRange() - 100 : ObjectManager.Player.GetRealAutoAttackRange())) && !SelectedOfGun && !CloseOfAARangeOfGun && !LowhpOfGun)
            {
                OutOfAARangeOfGun = true;
                //Calibrum
                if (ObjectManager.Player.HasBuff(loaded.CalibrumOff))
                {
                    if (ObjectManager.Player.HasBuff(loaded.SeverumOn) && W2)
                    {
                        if (OutAARange.Calibrum.Value > OutAARange.Severum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.GravitumOn) && W3)
                    {
                        if (OutAARange.Calibrum.Value > OutAARange.Gravitum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.InfernumOn) && W4)
                    {
                        if (OutAARange.Calibrum.Value > OutAARange.Infernum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.CrescendumOn) && W5)
                    {
                        if (OutAARange.Calibrum.Value > OutAARange.Crescendum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                }
                //Severum
                if (ObjectManager.Player.HasBuff(loaded.SeverumOff))
                {
                    if (ObjectManager.Player.HasBuff(loaded.CalibrumOn) && W1)
                    {
                        if(OutAARange.Severum.Value > OutAARange.Calibrum.Value)
                            if (loaded.W.Cast())
                            return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.GravitumOn) && W3)
                    {
                        if (OutAARange.Severum.Value > OutAARange.Gravitum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.InfernumOn) && W4)
                    {
                        if (OutAARange.Severum.Value > OutAARange.Infernum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.CrescendumOn) && W5)
                    {
                        if (OutAARange.Severum.Value > OutAARange.Crescendum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                }
                //Gravitum
                if (ObjectManager.Player.HasBuff(loaded.GravitumOff))
                {
                    if (ObjectManager.Player.HasBuff(loaded.SeverumOn) && W2)
                    {
                        if (OutAARange.Gravitum.Value > OutAARange.Severum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.CalibrumOn) && W1)
                    {
                        if (OutAARange.Gravitum.Value > OutAARange.Calibrum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.InfernumOn) && W4)
                    {
                        if (OutAARange.Gravitum.Value > OutAARange.Infernum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.CrescendumOn) && W5)
                    {
                        if (OutAARange.Gravitum.Value > OutAARange.Crescendum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                }
                //Infernum
                if (ObjectManager.Player.HasBuff(loaded.InfernumOff))
                {
                    if (ObjectManager.Player.HasBuff(loaded.SeverumOn) && W2)
                    {
                        if (OutAARange.Infernum.Value > OutAARange.Severum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.GravitumOn) && W3)
                    {
                        if (OutAARange.Infernum.Value > OutAARange.Gravitum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.CalibrumOn) && W1)
                    {
                        if (OutAARange.Infernum.Value > OutAARange.Calibrum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.CrescendumOn) && W5)
                    {
                        if (OutAARange.Infernum.Value > OutAARange.Crescendum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                }
                //Crescendum
                if (ObjectManager.Player.HasBuff(loaded.CrescendumOff))
                {
                    if (ObjectManager.Player.HasBuff(loaded.SeverumOn) && W2)
                    {
                        if (OutAARange.Crescendum.Value > OutAARange.Severum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.GravitumOn) && W3)
                    {
                        if (OutAARange.Crescendum.Value > OutAARange.Gravitum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.InfernumOn) && W4)
                    {
                        if (OutAARange.Crescendum.Value > OutAARange.Infernum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                    if (ObjectManager.Player.HasBuff(loaded.CalibrumOn) && W1)
                    {
                        if (OutAARange.Crescendum.Value > OutAARange.Calibrum.Value)
                            if (loaded.W.Cast())
                                return;
                    }
                }
            }
            else
            {
                OutOfAARangeOfGun = false;
            }
        }

        private static bool BeforeAA;
        private static bool OnAA;
        private static void Orbwalker_OnAction(object sender, OrbwalkerActionArgs args)
        {
            if (args.Type == OrbwalkerType.BeforeAttack)
            {
                BeforeAA = true;
                OnAA = false;
            } else
                BeforeAA = false;
            if (args.Type == OrbwalkerType.OnAttack)
            {
                OnAA = true;
                BeforeAA = false;
            }
            else
                OnAA = false;
        }

        private static void WQ(EventArgs args)
        {
            if (!Combo.WCombo.Enabled)
                return;
            if (ObjectManager.Player.IsDead || OnAA || BeforeAA)
                return;

            if (!loaded.W.IsReady() || TargetSelector.GetTarget(loaded.W.Range) == null)
            {
                return;
            }

            if (Orbwalker.ActiveMode > OrbwalkerMode.Harass)
                return;

            if (ObjectManager.Player.Mana < 60)
                return;
            var fstarget = FSTargetSelector.GetFSTarget(loaded.Q1.Range);
            if(fstarget != null)
            {
                if (fstarget.DistanceToPlayer() > (ObjectManager.Player.HasBuff(loaded.CalibrumOn) ? ObjectManager.Player.GetRealAutoAttackRange() - 100 : ObjectManager.Player.GetRealAutoAttackRange()))
                    return;

                if (fstarget.DistanceToPlayer() < (ObjectManager.Player.HasBuff(loaded.CalibrumOn) ? ObjectManager.Player.GetRealAutoAttackRange() - 100 : ObjectManager.Player.GetRealAutoAttackRange()))
                {
                    //Q1
                    if (loaded.Q1Ready && ObjectManager.Player.HasBuff(loaded.CalibrumOff))
                    {
                        var target = GameObjects.EnemyHeroes.Where(i => i != null && !i.IsDead && i.IsValidTarget(loaded.Q1.Range) && SebbyLibPorted.Prediction.Prediction.GetPrediction(loaded.Q1, i).Hitchance >= SebbyLibPorted.Prediction.HitChance.High);
                        if (target != null)
                        {
                            if (ObjectManager.Player.HasBuff(loaded.SeverumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(loaded.Q2.Range)) || !loaded.Q2.IsReady())
                                {
                                    //Game.Print("Cast W on WQ logic : " + loaded.CalibrumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                            if (ObjectManager.Player.HasBuff(loaded.GravitumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(loaded.Q3.Range) && i.HasBuff(loaded.GravitumDebuff)) || !loaded.Q3.IsReady())
                                {
                                    //Game.Print("Cast W on WQ logic : " + loaded.CalibrumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                            if (ObjectManager.Player.HasBuff(loaded.InfernumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(loaded.Q4.Range)) || !loaded.Q4.IsReady())
                                {
                                    //Game.Print("Cast W on WQ logic : " + loaded.CalibrumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                            if (ObjectManager.Player.HasBuff(loaded.CrescendumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(600)) || !loaded.Q5.IsReady())
                                {
                                    //Game.Print("Cast W on WQ logic : " + loaded.CalibrumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                        }
                        else
                        {
                            return;
                        }
                    }

                    //Q2
                    if (loaded.Q2Ready && ObjectManager.Player.HasBuff(loaded.SeverumOff))
                    {
                        var target = GameObjects.EnemyHeroes.Where(i => i != null && !i.IsDead && i.IsValidTarget(loaded.Q2.Range));
                        if (target != null)
                        {
                            if (ObjectManager.Player.HasBuff(loaded.CalibrumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(loaded.Q1.Range) && SebbyLibPorted.Prediction.Prediction.GetPrediction(loaded.Q1, i).Hitchance >= SebbyLibPorted.Prediction.HitChance.Collision) || !loaded.Q2.IsReady())
                                {
                                    //Game.Print("Cast W on WQ logic : " + loaded.SeverumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                            if (ObjectManager.Player.HasBuff(loaded.GravitumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(loaded.Q3.Range) && i.HasBuff(loaded.GravitumDebuff)) || !loaded.Q3.IsReady())
                                {
                                    //Game.Print("Cast W on WQ logic : " + loaded.SeverumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                            if (ObjectManager.Player.HasBuff(loaded.InfernumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(loaded.Q4.Range)) || !loaded.Q4.IsReady())
                                {
                                    //Game.Print("Cast W on WQ logic : " + loaded.SeverumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                            if (ObjectManager.Player.HasBuff(loaded.CrescendumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(600)) || !loaded.Q5.IsReady())
                                {
                                    //Game.Print("Cast W on WQ logic : " + loaded.SeverumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                        }
                        else
                        {
                            return;
                        }
                    }

                    //Q3
                    if (loaded.Q3Ready && ObjectManager.Player.HasBuff(loaded.GravitumOff))
                    {
                        var target = GameObjects.EnemyHeroes.Where(i => i != null && !i.IsDead && i.IsValidTarget(loaded.Q3.Range) && i.HasBuff(loaded.GravitumDebuff));
                        if (target != null)
                        {
                            if (ObjectManager.Player.HasBuff(loaded.CalibrumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(loaded.Q1.Range) && SebbyLibPorted.Prediction.Prediction.GetPrediction(loaded.Q1, i).Hitchance >= SebbyLibPorted.Prediction.HitChance.Collision) || !loaded.Q1.IsReady())
                                {
                                    //Game.Print("Cast W on WQ logic : " + loaded.GravitumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                            if (ObjectManager.Player.HasBuff(loaded.SeverumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(loaded.Q2.Range)) || !loaded.Q2.IsReady())
                                {
                                    //Game.Print("Cast W on WQ logic : " + loaded.GravitumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                            if (ObjectManager.Player.HasBuff(loaded.InfernumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(loaded.Q4.Range)) || !loaded.Q4.IsReady())
                                {
                                    //Game.Print("Cast W on WQ logic : " + loaded.GravitumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                            if (ObjectManager.Player.HasBuff(loaded.CrescendumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(600)) || !loaded.Q5.IsReady())
                                {
                                    //Game.Print("Cast W on WQ logic : " + loaded.GravitumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                        }
                        else
                        {
                            return;
                        }
                    }

                    //Q4
                    if (loaded.Q4Ready && ObjectManager.Player.HasBuff(loaded.InfernumOff))
                    {
                        var target = GameObjects.EnemyHeroes.Where(i => i != null && !i.IsDead && i.IsValidTarget(loaded.Q4.Range));
                        if (target != null)
                        {
                            if (ObjectManager.Player.HasBuff(loaded.CalibrumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(loaded.Q1.Range) && SebbyLibPorted.Prediction.Prediction.GetPrediction(loaded.Q1, i).Hitchance >= SebbyLibPorted.Prediction.HitChance.Collision) || !loaded.Q2.IsReady())
                                {
                                    //Game.Print("Cast W on WQ logic : " + loaded.InfernumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                            if (ObjectManager.Player.HasBuff(loaded.SeverumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(loaded.Q2.Range)) || !loaded.Q2.IsReady())
                                {
                                    //Game.Print("Cast W on WQ logic : " + loaded.InfernumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                            if (ObjectManager.Player.HasBuff(loaded.GravitumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(loaded.Q3.Range) && i.HasBuff(loaded.GravitumDebuff)) || !loaded.Q3.IsReady())
                                {
                                    //Game.Print("Cast W on WQ logic : " + loaded.InfernumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                            if (ObjectManager.Player.HasBuff(loaded.CrescendumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(600)) || !loaded.Q5.IsReady())
                                {
                                    //Game.Print("Cast W on WQ logic : " + loaded.InfernumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                    //Q4
                    if (loaded.Q5Ready && ObjectManager.Player.HasBuff(loaded.CrescendumOff))
                    {
                        var target = GameObjects.EnemyHeroes.Where(i => i != null && !i.IsDead && i.IsValidTarget(600));
                        if (target != null)
                        {
                            if (ObjectManager.Player.HasBuff(loaded.CalibrumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(loaded.Q1.Range) && SebbyLibPorted.Prediction.Prediction.GetPrediction(loaded.Q1, i).Hitchance >= SebbyLibPorted.Prediction.HitChance.Collision) || !loaded.Q2.IsReady())
                                {
                                    //Game.Print("Cast W on WQ logic : " + loaded.CrescendumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                            if (ObjectManager.Player.HasBuff(loaded.SeverumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(loaded.Q2.Range)) || !loaded.Q2.IsReady())
                                {
                                    //Game.Print("Cast W on WQ logic : " + loaded.CrescendumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                            if (ObjectManager.Player.HasBuff(loaded.InfernumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(loaded.Q4.Range)) || !loaded.Q4.IsReady())
                                {
                                    //Game.Print("Cast W on WQ logic : " + loaded.CrescendumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                            if (ObjectManager.Player.HasBuff(loaded.GravitumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(loaded.Q3.Range) && i.HasBuff(loaded.GravitumDebuff)) || !loaded.Q3.IsReady())
                                {
                                    //Game.Print("Cast W on WQ logic : " + loaded.CrescendumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                /*else
                {
                    //Q1
                    if (loaded.Q1Ready && ObjectManager.Player.HasBuff(loaded.CalibrumOff))
                    {
                        var target = GameObjects.EnemyHeroes.Where(i => i != null && !i.IsDead && i.IsValidTarget(loaded.Q1.Range) && SebbyLibPorted.Prediction.Prediction.GetPrediction(loaded.Q1, i).Hitchance >= SebbyLibPorted.Prediction.HitChance.High);
                        if (target != null)
                        {
                            if (ObjectManager.Player.HasBuff(loaded.SeverumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(loaded.Q2.Range)) || !loaded.Q2.IsReady())
                                {
                                    Game.Print("Cast W on WQ logic : " + loaded.CalibrumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                            if (ObjectManager.Player.HasBuff(loaded.GravitumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(loaded.Q3.Range) && i.HasBuff(loaded.GravitumDebuff)) || !loaded.Q3.IsReady())
                                {
                                    Game.Print("Cast W on WQ logic : " + loaded.CalibrumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }
 
                            if (ObjectManager.Player.HasBuff(loaded.InfernumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(loaded.Q4.Range)) || !loaded.Q4.IsReady())
                                {
                                    Game.Print("Cast W on WQ logic : " + loaded.CalibrumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                            if (ObjectManager.Player.HasBuff(loaded.CrescendumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(600)) || !loaded.Q5.IsReady())
                                {
                                    Game.Print("Cast W on WQ logic : " + loaded.CalibrumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }
                        }
                        else
                        {
                            return;
                        }
                    }

                    //Q2
                    if (loaded.Q2Ready && ObjectManager.Player.HasBuff(loaded.SeverumOff))
                    {
                        var target = GameObjects.EnemyHeroes.Where(i => i != null && !i.IsDead && i.IsValidTarget(loaded.Q2.Range));
                        if (target != null)
                        {
                            if (ObjectManager.Player.HasBuff(loaded.CalibrumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(loaded.Q1.Range) && SebbyLibPorted.Prediction.Prediction.GetPrediction(loaded.Q1, i).Hitchance >= SebbyLibPorted.Prediction.HitChance.Collision) || !loaded.Q2.IsReady())
                                {
                                    Game.Print("Cast W on WQ logic : " + loaded.SeverumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                            if (ObjectManager.Player.HasBuff(loaded.GravitumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(loaded.Q3.Range) && i.HasBuff(loaded.GravitumDebuff)) || !loaded.Q3.IsReady())
                                {
                                    Game.Print("Cast W on WQ logic : " + loaded.SeverumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                            if (ObjectManager.Player.HasBuff(loaded.InfernumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(loaded.Q4.Range)) || !loaded.Q4.IsReady())
                                {
                                    Game.Print("Cast W on WQ logic : " + loaded.SeverumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                            if (ObjectManager.Player.HasBuff(loaded.CrescendumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(600)) || !loaded.Q5.IsReady())
                                {
                                    Game.Print("Cast W on WQ logic : " + loaded.SeverumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }
                        }
                        else
                        {
                            return;
                        }
                    }

                    //Q3
                    if (loaded.Q3Ready && ObjectManager.Player.HasBuff(loaded.GravitumOff))
                    {
                        var target = GameObjects.EnemyHeroes.Where(i => i != null && !i.IsDead && i.IsValidTarget(loaded.Q3.Range) && i.HasBuff(loaded.GravitumDebuff));
                        if (target != null)
                        {
                            if (ObjectManager.Player.HasBuff(loaded.CalibrumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(loaded.Q1.Range) && SebbyLibPorted.Prediction.Prediction.GetPrediction(loaded.Q1, i).Hitchance >= SebbyLibPorted.Prediction.HitChance.Collision) || !loaded.Q1.IsReady())
                                {
                                    Game.Print("Cast W on WQ logic : " + loaded.GravitumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                            if (ObjectManager.Player.HasBuff(loaded.SeverumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(loaded.Q2.Range)) || !loaded.Q2.IsReady())
                                {
                                    Game.Print("Cast W on WQ logic : " + loaded.GravitumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                            if (ObjectManager.Player.HasBuff(loaded.InfernumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(loaded.Q4.Range)) || !loaded.Q4.IsReady())
                                {
                                    Game.Print("Cast W on WQ logic : " + loaded.GravitumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                            if (ObjectManager.Player.HasBuff(loaded.CrescendumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(600)) || !loaded.Q5.IsReady())
                                {
                                    Game.Print("Cast W on WQ logic : " + loaded.GravitumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }
                        }
                        else
                        {
                            return;
                        }
                    }

                    //Q4
                    if (loaded.Q4Ready && ObjectManager.Player.HasBuff(loaded.InfernumOff))
                    {
                        var target = GameObjects.EnemyHeroes.Where(i => i != null && !i.IsDead && i.IsValidTarget(loaded.Q4.Range));
                        if (target != null)
                        {
                            if (ObjectManager.Player.HasBuff(loaded.CalibrumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(loaded.Q1.Range) && SebbyLibPorted.Prediction.Prediction.GetPrediction(loaded.Q1, i).Hitchance >= SebbyLibPorted.Prediction.HitChance.Collision) || !loaded.Q2.IsReady())
                                {
                                    Game.Print("Cast W on WQ logic : " + loaded.InfernumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                            if (ObjectManager.Player.HasBuff(loaded.SeverumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(loaded.Q2.Range)) || !loaded.Q2.IsReady())
                                {
                                    Game.Print("Cast W on WQ logic : " + loaded.InfernumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                            if (ObjectManager.Player.HasBuff(loaded.GravitumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(loaded.Q3.Range) && i.HasBuff(loaded.GravitumDebuff)) || !loaded.Q3.IsReady())
                                {
                                    Game.Print("Cast W on WQ logic : " + loaded.InfernumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                            if (ObjectManager.Player.HasBuff(loaded.CrescendumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(600)) || !loaded.Q5.IsReady())
                                {
                                    Game.Print("Cast W on WQ logic : " + loaded.InfernumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                        }
                        else
                        {
                            return;
                        }
                    }
                    //Q5
                    if (loaded.Q5Ready && ObjectManager.Player.HasBuff(loaded.CrescendumOff))
                    {
                        var target = GameObjects.EnemyHeroes.Where(i => i != null && !i.IsDead && i.DistanceToPlayer() < 600);
                        if (target.Where(i => i.DistanceToPlayer() < 600) != null)
                        {
                            if (ObjectManager.Player.HasBuff(loaded.CalibrumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(loaded.Q1.Range) && SebbyLibPorted.Prediction.Prediction.GetPrediction(loaded.Q1, i).Hitchance >= SebbyLibPorted.Prediction.HitChance.Collision) || !loaded.Q2.IsReady())
                                {
                                    Game.Print("Cast W on WQ logic : " + loaded.CrescendumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                            if (ObjectManager.Player.HasBuff(loaded.SeverumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(loaded.Q2.Range)) || !loaded.Q2.IsReady())
                                {
                                    Game.Print("Cast W on WQ logic : " + loaded.CrescendumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                            if (ObjectManager.Player.HasBuff(loaded.InfernumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(loaded.Q4.Range)) || !loaded.Q4.IsReady())
                                {
                                    Game.Print("Cast W on WQ logic : " + loaded.CrescendumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }

                            if (ObjectManager.Player.HasBuff(loaded.GravitumOn))
                            {
                                if (!target.Any(i => i.IsValidTarget(loaded.Q3.Range) && i.HasBuff(loaded.GravitumDebuff)) || !loaded.Q3.IsReady())
                                {
                                    Game.Print("Cast W on WQ logic : " + loaded.CrescendumOff);
                                    if (loaded.W.Cast())
                                        return;
                                }
                                else
                                {
                                    return;
                                }
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                }*/
            }            
        }
    }
    
    public class loaded
    {
        public static string CalibrumOff = "ApheliosOffHandBuffCalibrum";
        public static string CalibrumOn = "ApheliosCalibrumManager";
        public static string SeverumOff = "ApheliosOffHandBuffSeverum";
        public static string SeverumOn = "ApheliosSeverumManager";
        public static string GravitumOff = "ApheliosOffHandBuffGravitum";
        public static string GravitumOn = "ApheliosGravitumManager";
        public static string InfernumOff = "ApheliosOffHandBuffInfernum";
        public static string InfernumOn = "ApheliosInfernumManager";
        public static string CrescendumOff = "ApheliosOffHandBuffCrescendum";
        public static string CrescendumOn = "ApheliosCrescendumManager";
        public static string CalibrumDebuff = "aphelioscalibrumbonusrangebuff";
        public static string GravitumDebuff = "ApheliosGravitumDebuff";
        public static Menu MAphelios = new Menu("Aphelios", "FunnySlayer Aphelios", true);
        private static AIHeroClient Player => ObjectManager.Player;
        public static Spell Q1 = new Spell(SpellSlot.Q);
        public static Spell Q2 = new Spell(SpellSlot.Q);
        public static Spell Q3 = new Spell(SpellSlot.Q);
        public static Spell Q4 = new Spell(SpellSlot.Q);
        public static Spell Q5 = new Spell(SpellSlot.Q);
        public static Spell W = new Spell(SpellSlot.W);
        public static Spell R = new Spell(SpellSlot.R);
        public static void OnLoad()
        {
            W.Range = float.MaxValue;
            R.Range = 1300;
            R.SetSkillshot(0.6f, 150, 2000f, false, SkillshotType.Line);
            Q1.Range = 1450f;
            Q2.Range = 550f;
            Q3.Range = float.MaxValue;
            Q4.Range = 650f;
            Q5.Range = 475f;
            Q1.SetSkillshot(0.4f, 100, 1850f, true, SkillshotType.Line);
            Q2.SetTargetted(0.25f, float.MaxValue);
            Q4.SetSkillshot(0.4f, 300, float.MaxValue, false, SkillshotType.Line);
            Q5.SetSkillshot(1f, 500, float.MaxValue, false, SkillshotType.Circle);
            Game.Print("<font color='#1dff00' size='25'>Aphelios The MachineGun loaded</font>");
            MAphelios.AddApheliosMenu();
            MAphelios.Attach();

            Game.OnUpdate += Game_OnUpdate;
            AIBaseClient.OnProcessSpellCast += AIBaseClient_OnProcessSpellCast;
            Game.OnUpdate += CheckQReady;
            Game.OnUpdate += CheckRGun;
            Game.OnUpdate += CheckQGUn;
            Drawing.OnDraw += Drawing_OnDraw;
        }

        private static void Game_OnUpdate(EventArgs args)
        {
            if (Player.IsDead)
                return;

            if (!R.IsReady() || !MenuSettings.Combo.RCombo.Enabled)
                return;

            var Rspell = new Spell(SpellSlot.Unknown, 1300);
            Rspell.SetSkillshot(0.6f, 250f, 2000f, false, SkillshotType.Circle);
            var target = FSTargetSelector.GetFSTarget(1300);
            if(target != null)
            {
                var pred = SebbyLibPorted.Prediction.Prediction.GetPrediction(Rspell, target);
                if(pred != null)
                {
                    if(pred.Hitchance >= SebbyLibPorted.Prediction.HitChance.High)
                    {
                        if(pred.AoeTargetsHitCount > 1)
                        {
                            if (R.Cast(pred.CastPosition))
                                return;
                        }
                        if(target.HealthPercent <= 50)
                        {
                            if (R.Cast(pred.CastPosition))
                                return;
                        }
                    }
                }
            }
        }

        private static void Drawing_OnDraw(EventArgs args)
        {
            if (Player.IsDead)
                return;

            if(DrawRange != float.MaxValue)
            {
                Render.Circle.DrawCircle(Player.Position, DrawRange, System.Drawing.Color.Red, 5);
            }
            var mana = Player.Mana < 60;
            var pos = Drawing.WorldToScreen(Player.Position);
            Drawing.DrawText(pos.X, pos.Y + 20, Q1Ready ? System.Drawing.Color.Green : System.Drawing.Color.Red, mana ? "Mana Not Enough" : "Calibrum");
            Drawing.DrawText(pos.X, pos.Y + 40, Q2Ready ? System.Drawing.Color.Green : System.Drawing.Color.Red, mana ? "Mana Not Enough" : "Severum");
            Drawing.DrawText(pos.X, pos.Y + 60, Q3Ready ? System.Drawing.Color.Green : System.Drawing.Color.Red, mana ? "Mana Not Enough" : "Gravitum");
            Drawing.DrawText(pos.X, pos.Y + 80, Q4Ready ? System.Drawing.Color.Green : System.Drawing.Color.Red, mana ? "Mana Not Enough" : "Infernum");
            Drawing.DrawText(pos.X, pos.Y + 100, Q5Ready ? System.Drawing.Color.Green : System.Drawing.Color.Red, mana ? "Mana Not Enough" : "Crescendum");
        }
        private static float DrawRange = float.MaxValue;
        private static void CheckQGUn(EventArgs args)
        {
            if (Player.HasBuff(CalibrumOn))
            {
                DrawRange = Q1.Range;
            }
            else
            {
                if (Player.HasBuff(SeverumOn))
                {
                    DrawRange = Q2.Range;
                }
                else
                {
                    if (Player.HasBuff(GravitumOn))
                    {
                        DrawRange = Q3.Range;
                    }
                    else
                    {
                        if (Player.HasBuff(InfernumOn))
                        {
                            DrawRange = Q4.Range;
                        }
                        else
                        {
                            if (Player.HasBuff(CrescendumOn))
                            {
                                DrawRange = Q5.Range;
                            }
                        }
                    }
                }
            }        
        }

        public static bool R1Ready = false;
        public static bool R2Ready = false;
        public static bool R3Ready = false;
        public static bool R4Ready = false;
        public static bool R5Ready = false;
        private static void CheckRGun(EventArgs args)
        {
            if (Player.Level == 1 || Player.Mana < 100)
                return;

            if (R.IsReady())
            {
                if(Player.HasBuff(CalibrumOff) || Player.HasBuff(CalibrumOn))
                {
                    R1Ready = true;
                }
                else
                {
                    R1Ready = false;
                }
                if (Player.HasBuff(SeverumOff) || Player.HasBuff(SeverumOn))
                {
                    R2Ready = true;
                }
                else
                {
                    R2Ready = false;
                }
                if (Player.HasBuff(GravitumOff) || Player.HasBuff(GravitumOn))
                {
                    R3Ready = true;
                }
                else
                {
                    R3Ready = false;
                }
                if (Player.HasBuff(InfernumOff) || Player.HasBuff(InfernumOn))
                {
                    R4Ready = true;
                }
                else
                {
                    R4Ready = false;
                }
                if (Player.HasBuff(CrescendumOff) || Player.HasBuff(CrescendumOn))
                {
                    R5Ready = true;
                }
                else
                {
                    R5Ready = false;
                }
            }
        }

        public static bool Q1Ready = false;
        public static bool Q2Ready = false;
        public static bool Q3Ready = false;
        public static bool Q4Ready = false;
        public static bool Q5Ready = false;
        private static void CheckQReady(EventArgs args)
        {
            if (Player.Level == 1 || Player.Mana < 60)
                return;

            if(Variables.TickCount >= lastCalibrum + GetQ1CD() * 1000)
            {
                Q1Ready = true;
            }
            else
            {
                Q1Ready = false;
            }
            if (Variables.TickCount >= lastSeverum + GetQ2CD() * 1000)
            {
                Q2Ready = true;
            }
            else
            {
                Q2Ready = false;
            }
            if (Variables.TickCount >= lastGravitum + GetQ3CD() * 1000)
            {
                Q3Ready = true;
            }
            else
            {
                Q3Ready = false;
            }
            if (Variables.TickCount >= lastInfernum + GetQ4CD() * 1000)
            {
                Q4Ready = true;
            }
            else
            {
                Q4Ready = false;
            }
            if (Variables.TickCount >= lastCrescendum + GetQ5CD() * 1000)
            {
                Q5Ready = true;
            }
            else
            {
                Q5Ready = false;
            }
        }

        public static int lastCalibrum = 0;
        public static int lastSeverum = 0;
        public static int lastGravitum = 0;
        public static int lastInfernum = 0;
        public static int lastCrescendum = 0;
        private static void AIBaseClient_OnProcessSpellCast(AIBaseClient sender, AIBaseClientProcessSpellCastEventArgs args)
        {
            if (sender == null || args == null)
                return;

            if (sender.IsMe)
            {
                if (args.SData.Name == "ApheliosCalibrumQ")
                {
                    lastCalibrum = Variables.TickCount;
                }
                if (args.SData.Name == "ApheliosSeverumQ")
                {
                    lastSeverum = Variables.TickCount;
                }
                if (args.SData.Name == "ApheliosGravitumQ")
                {
                    lastGravitum = Variables.TickCount;
                }
                if (args.SData.Name == "ApheliosInfernumQ")
                {
                    lastInfernum = Variables.TickCount;
                }
                if (args.SData.Name == "ApheliosCrescendumQ")
                {
                    lastCrescendum = Variables.TickCount;
                }
            }
        }
        private static int PlayerLevel()
        {
            if (ObjectManager.Player == null)
                return 0;

            if (ObjectManager.Player.Level >= 13)
                return 7;

            if (ObjectManager.Player.Level >= 11)
                return 6;

            if (ObjectManager.Player.Level >= 9)
                return 5;

            if (ObjectManager.Player.Level >= 7)
                return 4;

            if (ObjectManager.Player.Level >= 5)
                return 3;

            if (ObjectManager.Player.Level >= 3)
                return 2;

            if (ObjectManager.Player.Level > 1)
                return 1;

            return 0;
        }

        private static float GetQ1CD()
        {
            if (Player.Level == 1)
                return float.MaxValue;

            var array = new float[]
            {
                float.MaxValue, 10f, 9.67f, 9.33f, 9f, 8.67f, 8.33f, 8f
            };

            return array[PlayerLevel()] 
                + array[PlayerLevel()] * Player.PercentCooldownMod 
                - Game.Ping / 1000;
        }
        private static float GetQ2CD()
        {
            if (Player.Level == 1)
                return float.MaxValue;

            var array = new float[]
            {
                float.MaxValue, 10f, 9.67f, 9.33f, 9f, 8.67f, 8.33f, 8f
            };

            return array[PlayerLevel()] 
                + array[PlayerLevel()] * Player.PercentCooldownMod 
                - Game.Ping / 1000;
        }
        private static float GetQ3CD()
        {
            if (Player.Level == 1)
                return float.MaxValue;

            var array = new float[]
            {
                float.MaxValue, 12f, 11.67f, 11.33f, 11f, 10.67f, 10.33f, 10f
            };

            return array[PlayerLevel()] 
                + array[PlayerLevel()] * Player.PercentCooldownMod 
                - Game.Ping / 1000;
        }
        private static float GetQ4CD()
        {
            if (Player.Level == 1)
                return float.MaxValue;

            var array = new float[]
            {
                float.MaxValue, 9f, 8.5f, 8f, 7.5f, 7f, 6.5f, 6f
            };

            return array[PlayerLevel()] 
                + array[PlayerLevel()] * Player.PercentCooldownMod 
                - Game.Ping / 1000;
        }
        private static float GetQ5CD()
        {
            if (Player.Level == 1)
                return float.MaxValue;

            var array = new float[]
            {
                float.MaxValue, 9f, 8.5f, 8f, 7.5f, 7f, 6.5f, 6f
            };

            return array[PlayerLevel()] 
                + array[PlayerLevel()] * Player.PercentCooldownMod 
                - Game.Ping / 1000;
        }
    }
}
