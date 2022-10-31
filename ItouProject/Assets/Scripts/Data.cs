using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    public List<string> data = new List<string>() {
"あいだ", "あいて", "あお", "あか", "あさ", "あさごはん", "あさって", "あし", "あす", "あそこ", "あたま", "あちら", "あと", "あなた", "あに", "あめ", "あれ", "あんぜん", 
"いいん", "いえ", "いか", "いがい", "いけん", "いしき", "いじょう", "いす", "いずれ", "いぜん", "いち", "いちぶ", "いっしゅうかん", "いっしょ", "いっぱん", "いつ", "いつつ", "いぬ", "いま", "いみ", "いりょう", "いろ", 
"うえ", "うしろ", "うち", "うで", "うみ", "うんてん", "うんどう", 
"え", "えいが", "えいきょう", "えき", "えん", "えんぴつ", 
"おおく", "おかあさん", "おく", "おく", "おじ", "おじいさん", "おっと", "おと", "おとうさん", "おとこ", "おととい", "おなか", "おば", "おばあさん", "おまえ", "おや", "おんがく", "おんな", 
"か", "かい", "かい", "かい", "かいぎ", "かいしゃ", "かお", "かかく", "かがく", "かぎ", "かくにん", "かげつ", "かこ", "かさ", "かぜ", "かぜ", "かぞく", "かた", "かたかな", "かたち", "かつどう", "かね", "かのじょ", "かばん", "かべ", "かみ", "かみ", "かみ", "かようび", "からだ", "かれ", "かれら", "かわ", "かん", "かんきょう", "かんけい", "かんこく", "かんじ", "かんり", "がいこく", "がく", "がっこう", "がわ", 
"き", "き", "き", "き", "きいろ", "きかん", "きかん", "きけん", "きじゅん", "きた", "きたい", "きって", "きっぷ", "きのう", "きのう", "きほん", "きみ", "きもち", "きもの", "きゃく", "きゅう", "きょう", "きょういく", "きょうりょく", "きょく", "きん", "きんようび", "ぎじゅつ", "ぎんこう", 
"くうき", "くうこう", "くさ", "くだもの", "くち", "くつ", "くつした", "くに", "くび", "くもり", "くるま", "くろ", "ぐん", 
"け", "けいえい", "けいかく", "けいけん", "けいさつ", "けいざい", "けいやく", "けが", "けっか", "けっこん", "けってい", "けん", "けんきゅう", "けんこう", "けんとう", "げつようび", "げんいん", "げんかん", "げんざい", 
"こうか", "こうこう", "こうじょう", "こうぞう", "こうつう", "こうどう", "こえ", "こくさい", "こくみん", "ここ", "ここのつ", "こころ", "こじん", "こちら", "こと", "ことし", "ことば", "こども", "こめ", "これ", "ころ", "こんかい", "こんご", "こんど", "ご", "ご", "ごう", "ごご", "ごぜん", "ごはん", 
"さい", "さいきん", "さいご", "さいしょ", "さかな", "さき", "さぎょう", "さくせい", "さくひん", "さとう", "さん", "さんか", "さんぎょう", 
"し", "し", "しお", "しき", "しごと", "しぜん", "した", "しち", "しつもん", "してい", "しどう", "しみん", "しゃ", "しゃかい", "しゃしん", "しゅう", "しゅうかん", "しゅぎ", "しょうかい", "しょうがい", "しょうひ", "しょうひん", "しょうゆ", "しょうらい", "しょくじ", "しょり", "しよう", "しりょう", "しろ", "しんたい", "しんぱい", "しんぶん", "じ", "じかん", "じき", "じけん", "じこ", "じしょ", "じしん", "じだい", "じっさい", "じっし", "じてんしゃ", "じどう", "じぶん", "じむ", "じゅう", "じゅうたく", "じゆう", "じょうきょう", "じょうけん", "じょうたい", "じょうほう", 
"すいようび", "すう", "すがた", "すべて", "ず", 
"せいかつ", "せいき", "せいさん", "せいしん", "せいじ", "せいど", "せいび", "せいふ", "せかい", "せきにん", "せつめい", "せなか", "せん", "せんせい", "せんそう", "せんたく", "せんもん", "ぜい", "ぜんこく", "ぜんたい", 
"そうだん", "そこ", "そしき", "そちら", "そと", "そふ", "そぼ", "そら", "それ", "それぞれ", "そんざい", 
"た", "たいさく", "たいしょう", "たいふう", "たたみ", "ため", "だい", "だい", "だいがく", "だいじん", "だいどころ", "だいひょう", "だめ", "だれ", "だんたい", 
"ち", "ち", "ちいき", "ちかく", "ちから", "ちほう", "ちゃ", "ちゃわん", "ちゅうい", "ちゅうおう", "ちゅうごく", "ちゅうしん", "ちょうさ", "ちり", 
"ついたち", "つき", "つき", "つぎ", "つくえ", "つま", "つめ", "つもり", 
"て", "ていど", "てがみ", "てまえ", "てん", "てんき", "でんき", "でんしゃ", "でんわ", 
"と", "とうじ", "とお", "とおり", "とき", "ところ", "とし", "とし", "とち", "ともだち", "とり", "ど", "どう", "どうぐ", "どうじ", "どうぶつ", "どうろ", "どこ", "どちら", "どようび", "どれ", 
"ないよう", "なか", "ななつ", "なに", "なまえ", 
"に", "にく", "にし", "にちようび", "にっぽん", "にんげん", 
"ぬりえ",
"ねこ", "ねんかん", "ねんど", 
"のり",
"は", "は", "はし", "はず", "はち", "はな", "はな", "はれ", "はん", "はんだん", "はんばい", "ばあい", "ばしょ", "ばん", "ばん", 
"ひ", "ひ", "ひかり", "ひがし", "ひげ", "ひこうき", "ひだり", "ひつよう", "ひと", "ひとつ", "ひとびと", "ひとり", "ひゃく", "ひょう", "ひょうか", "ひょうげん", "ひらがな", "ひる", "ひるごはん", "びょう", "びょういん", "びょうき", 
"ふう", "ふく", "ふたつ", "ふたり", "ふつう", "ふとん", "ふろ", "ふん", "ぶ", "ぶどう", "ぶぶん", "ぶん", "ぶんか", 
"へや", "へんか", "べつ", "べんきょう", 
"ほう", "ほう", "ほうこく", "ほうそう", "ほうほう", "ほうりつ", "ほか", "ほし", "ほとんど", "ほん", "ほんだな", "ほんとう", "ぼく", 
"まいにち", "まえ", "まど", "まま", "まん", "まんなか", 
"み", "みぎ", "みず", "みせ", "みち", "みっつ", "みどり", "みな", "みなみ", "みみ", 
"むし", "むすめ", "むっつ", "むね", "むり", 
"め", "めがね", "めん", 
"もくてき", "もくようび", "もじ", "もと", "もの", "もの", "もんだい", 
"やく", "やさい", "やっつ", "やま", 
"ゆ", "ゆうがた", "ゆうごはん", "ゆき", "ゆび", "ゆめ", 
"ようび", "ようふく", "よっつ", "よてい", "よる", 
"らいおん", "らっぱ",
"りかい", "りつ", "りゆう", "りょう", "りょうり", "りよう", "りこん", "りぼん",
"れい", "れい", "れきし", "れんらく", 
"ろうか", "ろうどう", "ろく", 
"わけ", "わたし", "われわれ", 
"アパート", "アメリカ", "アラビア", "エスカレーター", "エレベーター", "カーテン", "ガス", "コップ", "コーヒー", "サラダ", "サービス", "シャープペンシル", "スペイン", "スポーツ", "センター", "タクシー", "テレビ", "テーブル", "トイレ", "ドア", "ドイツ", "ナイフ", "ネクタイ", "バス", "パソコン", "パン", "パーセント", "ベッド", "ペン", "ページ", "ホテル", "ボタン", "ボールペン", "メートル", "メール"};

    public List<string> sound50 = new List<string>()
    {
"あ", "い", "う", "え", "お",
"か", "き", "く", "け", "こ",
"さ", "し", "す", "せ", "そ",
"た", "ち", "つ", "て", "と",
"な", "に", "ぬ", "ね", "の",
"は", "ひ", "ふ", "へ", "ほ",
"ま", "み", "む", "め", "も",
"や", "ゆ", "よ",
"ら", "り", "る", "れ", "ろ",
"わ"
    };
    

    public static string[] a = new string[] {"あいだ", "あいて", "あお", "あか", "あさ", "あさごはん", "あさって", "あし", "あす", "あそこ", "あたま", "あちら", "あと", "あなた", "あに", "あめ", "あれ", "あんぜん", 
    };
    public static string[] i = new string[] {"いいん", "いえ", "いか", "いがい", "いけん", "いしき", "いじょう", "いす", "いずれ", "いぜん", "いち", "いちぶ", "いっしゅうかん", "いっしょ", "いっぱん", "いつ", "いつつ", "いぬ", "いま", "いみ", "いりょう", "いろ", 
    };
    public static string[] u = new string[] {"うえ", "うしろ", "うち", "うで", "うみ", "うんてん", "うんどう", 
    };
    public static string[] e = new string[] {"え", "えいが", "えいきょう", "えき", "えん", "えんぴつ", 
    };
    public static string[] o = new string[] {"おおく", "おかあさん", "おく", "おく", "おじ", "おじいさん", "おっと", "おと", "おとうさん", "おとこ", "おととい", "おなか", "おば", "おばあさん", "おまえ", "おや", "おんがく", "おんな", 
    };
    public static string[] ka = new string[] {"か", "かい", "かい", "かい", "かいぎ", "かいしゃ", "かお", "かかく", "かがく", "かぎ", "かくにん", "かげつ", "かこ", "かさ", "かぜ", "かぜ", "かぞく", "かた", "かたかな", "かたち", "かつどう", "かね", "かのじょ", "かばん", "かべ", "かみ", "かみ", "かみ", "かようび", "からだ", "かれ", "かれら", "かわ", "かん", "かんきょう", "かんけい", "かんこく", "かんじ", "かんり", "がいこく", "がく", "がっこう", "がわ", 
    };
    public static string[] ki = new string[] {"き", "き", "き", "き", "きいろ", "きかん", "きかん", "きけん", "きじゅん", "きた", "きたい", "きって", "きっぷ", "きのう", "きのう", "きほん", "きみ", "きもち", "きもの", "きゃく", "きゅう", "きょう", "きょういく", "きょうりょく", "きょく", "きん", "きんようび", "ぎじゅつ", "ぎんこう", 
    };
    public static string[] ku = new string[] {"くうき", "くうこう", "くさ", "くだもの", "くち", "くつ", "くつした", "くに", "くび", "くもり", "くるま", "くろ", "ぐん", 
    };
    public static string[] ke = new string[] {"け", "けいえい", "けいかく", "けいけん", "けいさつ", "けいざい", "けいやく", "けが", "けっか", "けっこん", "けってい", "けん", "けんきゅう", "けんこう", "けんとう", "げつようび", "げんいん", "げんかん", "げんざい", 
    };
    public static string[] ko = new string[] {"こうか", "こうこう", "こうじょう", "こうぞう", "こうつう", "こうどう", "こえ", "こくさい", "こくみん", "ここ", "ここのつ", "こころ", "こじん", "こちら", "こと", "ことし", "ことば", "こども", "こめ", "これ", "ころ", "こんかい", "こんご", "こんど", "ご", "ご", "ごう", "ごご", "ごぜん", "ごはん", 
    };
    public static string[] sa = new string[] {"さい", "さいきん", "さいご", "さいしょ", "さかな", "さき", "さぎょう", "さくせい", "さくひん", "さとう", "さん", "さんか", "さんぎょう", 
    };
    public static string[] si = new string[] { "し", "し", "しお", "しき", "しごと", "しぜん", "した", "しち", "しつもん", "してい", "しどう", "しみん", "しゃ", "しゃかい", "しゃしん", "しゅう", "しゅうかん", "しゅぎ", "しょうかい", "しょうがい", "しょうひ", "しょうひん", "しょうゆ", "しょうらい", "しょくじ", "しょり", "しよう", "しりょう", "しろ", "しんたい", "しんぱい", "しんぶん", "じ", "じかん", "じき", "じけん", "じこ", "じしょ", "じしん", "じだい", "じっさい", "じっし", "じてんしゃ", "じどう", "じぶん", "じむ", "じゅう", "じゅうたく", "じゆう", "じょうきょう", "じょうけん", "じょうたい", "じょうほう", 
    };
    public static string[] su = new string[] { "すいようび", "すう", "すがた", "すべて", "ず", 
    };
    public static string[] se = new string[] { "せいかつ", "せいき", "せいさん", "せいしん", "せいじ", "せいど", "せいび", "せいふ", "せかい", "せきにん", "せつめい", "せなか", "せん", "せんせい", "せんそう", "せんたく", "せんもん", "ぜい", "ぜんこく", "ぜんたい", 
    };
    public static string[] so = new string[] {"そうだん", "そこ", "そしき", "そちら", "そと", "そふ", "そぼ", "そら", "それ", "それぞれ", "そんざい", 
    };
    public static string[] ta = new string[] {"た", "たいさく", "たいしょう", "たいふう", "たたみ", "ため", "だい", "だい", "だいがく", "だいじん", "だいどころ", "だいひょう", "だめ", "だれ", "だんたい", 
    };
    public static string[] ti = new string[] {"ち", "ち", "ちいき", "ちかく", "ちから", "ちほう", "ちゃ", "ちゃわん", "ちゅうい", "ちゅうおう", "ちゅうごく", "ちゅうしん", "ちょうさ", "ちり", 
    };
    public static string[] tu = new string[] {"ついたち", "つき", "つき", "つぎ", "つくえ", "つま", "つめ", "つもり", 
    };
    public static string[] te = new string[] {"て", "ていど", "てがみ", "てまえ", "てん", "てんき", "でんき", "でんしゃ", "でんわ", 
    };
    public static string[] to = new string[] {"と", "とうじ", "とお", "とおり", "とき", "ところ", "とし", "とし", "とち", "ともだち", "とり", "ど", "どう", "どうぐ", "どうじ", "どうぶつ", "どうろ", "どこ", "どちら", "どようび", "どれ", 
    };
    public static string[] na = new string[] {"ないよう", "なか", "ななつ", "なに", "なまえ", 
    };
    public static string[] ni = new string[] {"に", "にく", "にし", "にちようび", "にっぽん", "にんげん", 
    };
    public static string[] nu = new string[] {"ぬりえ",
    };
    public static string[] ne = new string[] {"ねこ", "ねんかん", "ねんど", 
    };
    public static string[] no = new string[] {"のり",
    };
    public static string[] ha = new string[] {"は", "は", "はし", "はず", "はち", "はな", "はな", "はれ", "はん", "はんだん", "はんばい", "ばあい", "ばしょ", "ばん", "ばん", 
    };
    public static string[] hi = new string[] {"ひ", "ひ", "ひかり", "ひがし", "ひげ", "ひこうき", "ひだり", "ひつよう", "ひと", "ひとつ", "ひとびと", "ひとり", "ひゃく", "ひょう", "ひょうか", "ひょうげん", "ひらがな", "ひる", "ひるごはん", "びょう", "びょういん", "びょうき", 
    };
    public static string[] hu = new string[] {"ふう", "ふく", "ふたつ", "ふたり", "ふつう", "ふとん", "ふろ", "ふん", "ぶ", "ぶどう", "ぶぶん", "ぶん", "ぶんか", 
    };
    public static string[] he = new string[] {"へや", "へんか", "べつ", "べんきょう", 
    };
    public static string[] ho = new string[] {"ほう", "ほう", "ほうこく", "ほうそう", "ほうほう", "ほうりつ", "ほか", "ほし", "ほとんど", "ほん", "ほんだな", "ほんとう", "ぼく", 
    };
    public static string[] ma = new string[] {"まいにち", "まえ", "まど", "まま", "まん", "まんなか", 
    };
    public static string[] mi = new string[] {"み", "みぎ", "みず", "みせ", "みち", "みっつ", "みどり", "みな", "みなみ", "みみ", 
    };
    public static string[] mu = new string[] {"むし", "むすめ", "むっつ", "むね", "むり", 
    };
    public static string[] me = new string[] {"め", "めがね", "めん", 
    };
    public static string[] mo = new string[] {"もくてき", "もくようび", "もじ", "もと", "もの", "もの", "もんだい", 
    };
    public static string[] ya = new string[] {"やく", "やさい", "やっつ", "やま", 
    };
    public static string[] yu = new string[] {"ゆ", "ゆうがた", "ゆうごはん", "ゆき", "ゆび", "ゆめ", 
    };
    public static string[] yo = new string[] {"ようび", "ようふく", "よっつ", "よてい", "よる", 
    };
    public static string[] ra = new string[] {"らいおん", "らっぱ",
    };
    public static string[] ri = new string[] {"りかい", "りつ", "りゆう", "りょう", "りょうり", "りよう", "りこん", "りぼん","りいす"
    };
    public static string[] ru = new string[] {"るーる"};
    public static string[] re = new string[] {"れい", "れい", "れきし", "れんらく", 
    };
    public static string[] ro = new string[] {"ろうか", "ろうどう", "ろく", 
    };
    public static string[] wa = new string[] {"わけ", "わたし", "われわれ", 
    };
    
    public static string[] ka2 = new string[] { };
    public static string[] ka3 = new string[] { };
    public static string[] ka4 = new string[] { };
    public static string[] ka5 = new string[] { };
    public static string[] ka6 = new string[] { };
    public static string[] ka7 = new string[] { };
    public static string[] ka8 = new string[] { };
    public static string[] ki2 = new string[] { };
    public static string[] ki3 = new string[] { };
    public static string[] ki4 = new string[] { };
    public static string[] ki5 = new string[] { };
    public static string[] ki6 = new string[] { };
    public static string[] ki7 = new string[] { };
    public static string[] ki8 = new string[] { };
    public static string[] ku2 = new string[] { };
    public static string[] ku3 = new string[] { };
    public static string[] ku4 = new string[] { };
    public static string[] ku5 = new string[] { };
    public static string[] ku6 = new string[] { };
    public static string[] ku7 = new string[] { };
    public static string[] ku8 = new string[] { };
    public static string[] ke2 = new string[] { };
    public static string[] ke3 = new string[] { };
    public static string[] ke4 = new string[] { };
    public static string[] ke5 = new string[] { };
    public static string[] ke6 = new string[] { };
    public static string[] ke7 = new string[] { };
    public static string[] ke8 = new string[] { };
    public static string[] ko2 = new string[] { };
    public static string[] ko3 = new string[] { };
    public static string[] ko4 = new string[] { };
    public static string[] ko5 = new string[] { };
    public static string[] ko6 = new string[] { };
    public static string[] ko7 = new string[] { };
    public static string[] ko8 = new string[] { };
    
    public static string[] sa2 = new string[] { };
    public static string[] sa3 = new string[] { };
    public static string[] sa4 = new string[] { };
    public static string[] sa5 = new string[] { };
    public static string[] sa6 = new string[] { };
    public static string[] sa7 = new string[] { };
    public static string[] sa8 = new string[] { };
    public static string[] si2 = new string[] { };
    public static string[] si3 = new string[] { };
    public static string[] si4 = new string[] { };
    public static string[] si5 = new string[] { };
    public static string[] si6 = new string[] { };
    public static string[] si7 = new string[] { };
    public static string[] si8 = new string[] { };
    public static string[] su2 = new string[] { };
    public static string[] su3 = new string[] { };
    public static string[] su4 = new string[] { };
    public static string[] su5 = new string[] { };
    public static string[] su6 = new string[] { };
    public static string[] su7 = new string[] { };
    public static string[] su8 = new string[] { };
    public static string[] se2 = new string[] { };
    public static string[] se3 = new string[] { };
    public static string[] se4 = new string[] { };
    public static string[] se5 = new string[] { };
    public static string[] se6 = new string[] { };
    public static string[] se7 = new string[] { };
    public static string[] se8 = new string[] { };
    public static string[] so2 = new string[] { };
    public static string[] so3 = new string[] { };
    public static string[] so4 = new string[] { };
    public static string[] so5 = new string[] { };
    public static string[] so6 = new string[] { };
    public static string[] so7 = new string[] { };
    public static string[] so8 = new string[] { };
    
    public static string[] ta2 = new string[] { };
    public static string[] ta3 = new string[] { };
    public static string[] ta4 = new string[] { };
    public static string[] ta5 = new string[] { };
    public static string[] ta6 = new string[] { };
    public static string[] ta7 = new string[] { };
    public static string[] ta8 = new string[] { };
    public static string[] ti2 = new string[] { };
    public static string[] ti3 = new string[] { };
    public static string[] ti4 = new string[] { };
    public static string[] ti5 = new string[] { };
    public static string[] ti6 = new string[] { };
    public static string[] ti7 = new string[] { };
    public static string[] ti8 = new string[] { };
    public static string[] tu2 = new string[] { };
    public static string[] tu3 = new string[] { };
    public static string[] tu4 = new string[] { };
    public static string[] tu5 = new string[] { };
    public static string[] tu6 = new string[] { };
    public static string[] tu7 = new string[] { };
    public static string[] tu8 = new string[] { };
    public static string[] te2 = new string[] { };
    public static string[] te3 = new string[] { };
    public static string[] te4 = new string[] { };
    public static string[] te5 = new string[] { };
    public static string[] te6 = new string[] { };
    public static string[] te7 = new string[] { };
    public static string[] te8 = new string[] { };
    public static string[] to2 = new string[] { };
    public static string[] to3 = new string[] { };
    public static string[] to4 = new string[] { };
    public static string[] to5 = new string[] { };
    public static string[] to6 = new string[] { };
    public static string[] to7 = new string[] { };
    public static string[] to8 = new string[] { };
    
    public static string[] na2 = new string[] { };
    public static string[] na3 = new string[] { };
    public static string[] na4 = new string[] { };
    public static string[] na5 = new string[] { };
    public static string[] na6 = new string[] { };
    public static string[] na7 = new string[] { };
    public static string[] na8 = new string[] { };
    public static string[] ni2 = new string[] { };
    public static string[] ni3 = new string[] { };
    public static string[] ni4 = new string[] { };
    public static string[] ni5 = new string[] { };
    public static string[] ni6 = new string[] { };
    public static string[] ni7 = new string[] { };
    public static string[] ni8 = new string[] { };
    public static string[] nu2 = new string[] { };
    public static string[] nu3 = new string[] { };
    public static string[] nu4 = new string[] { };
    public static string[] nu5 = new string[] { };
    public static string[] nu6 = new string[] { };
    public static string[] nu7 = new string[] { };
    public static string[] nu8 = new string[] { };
    public static string[] ne2 = new string[] { };
    public static string[] ne3 = new string[] { };
    public static string[] ne4 = new string[] { };
    public static string[] ne5 = new string[] { };
    public static string[] ne6 = new string[] { };
    public static string[] ne7 = new string[] { };
    public static string[] ne8 = new string[] { };
    public static string[] no2 = new string[] { };
    public static string[] no3 = new string[] { };
    public static string[] no4 = new string[] { };
    public static string[] no5 = new string[] { };
    public static string[] no6 = new string[] { };
    public static string[] no7 = new string[] { };
    public static string[] no8 = new string[] { };
    
    public static string[] ha2 = new string[] { };
    public static string[] ha3 = new string[] { };
    public static string[] ha4 = new string[] { };
    public static string[] ha5 = new string[] { };
    public static string[] ha6 = new string[] { };
    public static string[] ha7 = new string[] { };
    public static string[] ha8 = new string[] { };
    public static string[] hi2 = new string[] { };
    public static string[] hi3 = new string[] { };
    public static string[] hi4 = new string[] { };
    public static string[] hi5 = new string[] { };
    public static string[] hi6 = new string[] { };
    public static string[] hi7 = new string[] { };
    public static string[] hi8 = new string[] { };
    public static string[] hu2 = new string[] { };
    public static string[] hu3 = new string[] { };
    public static string[] hu4 = new string[] { };
    public static string[] hu5 = new string[] { };
    public static string[] hu6 = new string[] { };
    public static string[] hu7 = new string[] { };
    public static string[] hu8 = new string[] { };
    public static string[] he2 = new string[] { };
    public static string[] he3 = new string[] { };
    public static string[] he4 = new string[] { };
    public static string[] he5 = new string[] { };
    public static string[] he6 = new string[] { };
    public static string[] he7 = new string[] { };
    public static string[] he8 = new string[] { };
    public static string[] ho2 = new string[] { };
    public static string[] ho3 = new string[] { };
    public static string[] ho4 = new string[] { };
    public static string[] ho5 = new string[] { };
    public static string[] ho6 = new string[] { };
    public static string[] ho7 = new string[] { };
    public static string[] ho8 = new string[] { };
    
    public static string[] ma2 = new string[] { };
    public static string[] ma3 = new string[] { };
    public static string[] ma4 = new string[] { };
    public static string[] ma5 = new string[] { };
    public static string[] ma6 = new string[] { };
    public static string[] ma7 = new string[] { };
    public static string[] ma8 = new string[] { };
    public static string[] mi2 = new string[] { };
    public static string[] mi3 = new string[] { };
    public static string[] mi4 = new string[] { };
    public static string[] mi5 = new string[] { };
    public static string[] mi6 = new string[] { };
    public static string[] mi7 = new string[] { };
    public static string[] mi8 = new string[] { };
    public static string[] mu2 = new string[] { };
    public static string[] mu3 = new string[] { };
    public static string[] mu4 = new string[] { };
    public static string[] mu5 = new string[] { };
    public static string[] mu6 = new string[] { };
    public static string[] mu7 = new string[] { };
    public static string[] mu8 = new string[] { };
    public static string[] me2 = new string[] { };
    public static string[] me3 = new string[] { };
    public static string[] me4 = new string[] { };
    public static string[] me5 = new string[] { };
    public static string[] me6 = new string[] { };
    public static string[] me7 = new string[] { };
    public static string[] me8 = new string[] { };
    public static string[] mo2 = new string[] { };
    public static string[] mo3 = new string[] { };
    public static string[] mo4 = new string[] { };
    public static string[] mo5 = new string[] { };
    public static string[] mo6 = new string[] { };
    public static string[] mo7 = new string[] { };
    public static string[] mo8 = new string[] { };
    
    public static string[] ya2 = new string[] { };
    public static string[] ya3 = new string[] { };
    public static string[] ya4 = new string[] { };
    public static string[] ya5 = new string[] { };
    public static string[] ya6 = new string[] { };
    public static string[] ya7 = new string[] { };
    public static string[] ya8 = new string[] { };
    public static string[] yi2 = new string[] { };
    public static string[] yi3 = new string[] { };
    public static string[] yi4 = new string[] { };
    public static string[] yi5 = new string[] { };
    public static string[] yi6 = new string[] { };
    public static string[] yi7 = new string[] { };
    public static string[] yi8 = new string[] { };
    public static string[] yu2 = new string[] { };
    public static string[] yu3 = new string[] { };
    public static string[] yu4 = new string[] { };
    public static string[] yu5 = new string[] { };
    public static string[] yu6 = new string[] { };
    public static string[] yu7 = new string[] { };
    public static string[] yu8 = new string[] { };
    public static string[] ye2 = new string[] { };
    public static string[] ye3 = new string[] { };
    public static string[] ye4 = new string[] { };
    public static string[] ye5 = new string[] { };
    public static string[] ye6 = new string[] { };
    public static string[] ye7 = new string[] { };
    public static string[] ye8 = new string[] { };
    public static string[] yo2 = new string[] { };
    public static string[] yo3 = new string[] { };
    public static string[] yo4 = new string[] { };
    public static string[] yo5 = new string[] { };
    public static string[] yo6 = new string[] { };
    public static string[] yo7 = new string[] { };
    public static string[] yo8 = new string[] { };
    
    public static string[] ra2 = new string[] { };
    public static string[] ra3 = new string[] { };
    public static string[] ra4 = new string[] { };
    public static string[] ra5 = new string[] { };
    public static string[] ra6 = new string[] { };
    public static string[] ra7 = new string[] { };
    public static string[] ra8 = new string[] { };
    public static string[] ri2 = new string[] { };
    public static string[] ri3 = new string[] { };
    public static string[] ri4 = new string[] { };
    public static string[] ri5 = new string[] { };
    public static string[] ri6 = new string[] { };
    public static string[] ri7 = new string[] { };
    public static string[] ri8 = new string[] { };
    public static string[] ru2 = new string[] { };
    public static string[] ru3 = new string[] { };
    public static string[] ru4 = new string[] { };
    public static string[] ru5 = new string[] { };
    public static string[] ru6 = new string[] { };
    public static string[] ru7 = new string[] { };
    public static string[] ru8 = new string[] { };
    public static string[] re2 = new string[] { };
    public static string[] re3 = new string[] { };
    public static string[] re4 = new string[] { };
    public static string[] re5 = new string[] { };
    public static string[] re6 = new string[] { };
    public static string[] re7 = new string[] { };
    public static string[] re8 = new string[] { };
    public static string[] ro2 = new string[] { };
    public static string[] ro3 = new string[] { };
    public static string[] ro4 = new string[] { };
    public static string[] ro5 = new string[] { };
    public static string[] ro6 = new string[] { };
    public static string[] ro7 = new string[] { };
    public static string[] ro8 = new string[] { };
    
    public static string[] wa2 = new string[] { };
    public static string[] wa3 = new string[] { };
    public static string[] wa4 = new string[] { };
    public static string[] wa5 = new string[] { };
    public static string[] wa6 = new string[] { };
    public static string[] wa7 = new string[] { };
    public static string[] wa8 = new string[] { };
    public static string[] wi2 = new string[] { };
    public static string[] wi3 = new string[] { };
    public static string[] wi4 = new string[] { };
    public static string[] wi5 = new string[] { };
    public static string[] wi6 = new string[] { };
    public static string[] wi7 = new string[] { };
    public static string[] wi8 = new string[] { };
    public static string[] wu2 = new string[] { };
    public static string[] wu3 = new string[] { };
    public static string[] wu4 = new string[] { };
    public static string[] wu5 = new string[] { };
    public static string[] wu6 = new string[] { };
    public static string[] wu7 = new string[] { };
    public static string[] wu8 = new string[] { };
    public static string[] we2 = new string[] { };
    public static string[] we3 = new string[] { };
    public static string[] we4 = new string[] { };
    public static string[] we5 = new string[] { };
    public static string[] we6 = new string[] { };
    public static string[] we7 = new string[] { };
    public static string[] we8 = new string[] { };
    public static string[] wo2 = new string[] { };
    public static string[] wo3 = new string[] { };
    public static string[] wo4 = new string[] { };
    public static string[] wo5 = new string[] { };
    public static string[] wo6 = new string[] { };
    public static string[] wo7 = new string[] { };
    public static string[] wo8 = new string[] { };
    
    public static string[] ga2 = new string[] { };
    public static string[] ga3 = new string[] { };
    public static string[] ga4 = new string[] { };
    public static string[] ga5 = new string[] { };
    public static string[] ga6 = new string[] { };
    public static string[] ga7 = new string[] { };
    public static string[] ga8 = new string[] { };
    public static string[] gi2 = new string[] { };
    public static string[] gi3 = new string[] { };
    public static string[] gi4 = new string[] { };
    public static string[] gi5 = new string[] { };
    public static string[] gi6 = new string[] { };
    public static string[] gi7 = new string[] { };
    public static string[] gi8 = new string[] { };
    public static string[] gu2 = new string[] { };
    public static string[] gu3 = new string[] { };
    public static string[] gu4 = new string[] { };
    public static string[] gu5 = new string[] { };
    public static string[] gu6 = new string[] { };
    public static string[] gu7 = new string[] { };
    public static string[] gu8 = new string[] { };
    public static string[] ge2 = new string[] { };
    public static string[] ge3 = new string[] { };
    public static string[] ge4 = new string[] { };
    public static string[] ge5 = new string[] { };
    public static string[] ge6 = new string[] { };
    public static string[] ge7 = new string[] { };
    public static string[] ge8 = new string[] { };
    public static string[] go2 = new string[] { };
    public static string[] go3 = new string[] { };
    public static string[] go4 = new string[] { };
    public static string[] go5 = new string[] { };
    public static string[] go6 = new string[] { };
    public static string[] go7 = new string[] { };
    public static string[] go8 = new string[] { };
    
    public static string[] za2 = new string[] { };
    public static string[] za3 = new string[] { };
    public static string[] za4 = new string[] { };
    public static string[] za5 = new string[] { };
    public static string[] za6 = new string[] { };
    public static string[] za7 = new string[] { };
    public static string[] za8 = new string[] { };
    public static string[] zi2 = new string[] { };
    public static string[] zi3 = new string[] { };
    public static string[] zi4 = new string[] { };
    public static string[] zi5 = new string[] { };
    public static string[] zi6 = new string[] { };
    public static string[] zi7 = new string[] { };
    public static string[] zi8 = new string[] { };
    public static string[] zu2 = new string[] { };
    public static string[] zu3 = new string[] { };
    public static string[] zu4 = new string[] { };
    public static string[] zu5 = new string[] { };
    public static string[] zu6 = new string[] { };
    public static string[] zu7 = new string[] { };
    public static string[] zu8 = new string[] { };
    public static string[] ze2 = new string[] { };
    public static string[] ze3 = new string[] { };
    public static string[] ze4 = new string[] { };
    public static string[] ze5 = new string[] { };
    public static string[] ze6 = new string[] { };
    public static string[] ze7 = new string[] { };
    public static string[] ze8 = new string[] { };
    public static string[] zo2 = new string[] { };
    public static string[] zo3 = new string[] { };
    public static string[] zo4 = new string[] { };
    public static string[] zo5 = new string[] { };
    public static string[] zo6 = new string[] { };
    public static string[] zo7 = new string[] { };
    public static string[] zo8 = new string[] { };
    
    public static string[] da2 = new string[] { };
    public static string[] da3 = new string[] { };
    public static string[] da4 = new string[] { };
    public static string[] da5 = new string[] { };
    public static string[] da6 = new string[] { };
    public static string[] da7 = new string[] { };
    public static string[] da8 = new string[] { };
    public static string[] di2 = new string[] { };
    public static string[] di3 = new string[] { };
    public static string[] di4 = new string[] { };
    public static string[] di5 = new string[] { };
    public static string[] di6 = new string[] { };
    public static string[] di7 = new string[] { };
    public static string[] di8 = new string[] { };
    public static string[] du2 = new string[] { };
    public static string[] du3 = new string[] { };
    public static string[] du4 = new string[] { };
    public static string[] du5 = new string[] { };
    public static string[] du6 = new string[] { };
    public static string[] du7 = new string[] { };
    public static string[] du8 = new string[] { };
    public static string[] de2 = new string[] { };
    public static string[] de3 = new string[] { };
    public static string[] de4 = new string[] { };
    public static string[] de5 = new string[] { };
    public static string[] de6 = new string[] { };
    public static string[] de7 = new string[] { };
    public static string[] de8 = new string[] { };
    public static string[] do2 = new string[] { };
    public static string[] do3 = new string[] { };
    public static string[] do4 = new string[] { };
    public static string[] do5 = new string[] { };
    public static string[] do6 = new string[] { };
    public static string[] do7 = new string[] { };
    public static string[] do8 = new string[] { };
    
    public static string[] ba2 = new string[] { };
    public static string[] ba3 = new string[] { };
    public static string[] ba4 = new string[] { };
    public static string[] ba5 = new string[] { };
    public static string[] ba6 = new string[] { };
    public static string[] ba7 = new string[] { };
    public static string[] ba8 = new string[] { };
    public static string[] bi2 = new string[] { };
    public static string[] bi3 = new string[] { };
    public static string[] bi4 = new string[] { };
    public static string[] bi5 = new string[] { };
    public static string[] bi6 = new string[] { };
    public static string[] bi7 = new string[] { };
    public static string[] bi8 = new string[] { };
    public static string[] bu2 = new string[] { };
    public static string[] bu3 = new string[] { };
    public static string[] bu4 = new string[] { };
    public static string[] bu5 = new string[] { };
    public static string[] bu6 = new string[] { };
    public static string[] bu7 = new string[] { };
    public static string[] bu8 = new string[] { };
    public static string[] be2 = new string[] { };
    public static string[] be3 = new string[] { };
    public static string[] be4 = new string[] { };
    public static string[] be5 = new string[] { };
    public static string[] be6 = new string[] { };
    public static string[] be7 = new string[] { };
    public static string[] be8 = new string[] { };
    public static string[] bo2 = new string[] { };
    public static string[] bo3 = new string[] { };
    public static string[] bo4 = new string[] { };
    public static string[] bo5 = new string[] { };
    public static string[] bo6 = new string[] { };
    public static string[] bo7 = new string[] { };
    public static string[] bo8 = new string[] { };
    
    public static string[] pa2 = new string[] { };
    public static string[] pa3 = new string[] { };
    public static string[] pa4 = new string[] { };
    public static string[] pa5 = new string[] { };
    public static string[] pa6 = new string[] { };
    public static string[] pa7 = new string[] { };
    public static string[] pa8 = new string[] { };
    public static string[] pi2 = new string[] { };
    public static string[] pi3 = new string[] { };
    public static string[] pi4 = new string[] { };
    public static string[] pi5 = new string[] { };
    public static string[] pi6 = new string[] { };
    public static string[] pi7 = new string[] { };
    public static string[] pi8 = new string[] { };
    public static string[] pu2 = new string[] { };
    public static string[] pu3 = new string[] { };
    public static string[] pu4 = new string[] { };
    public static string[] pu5 = new string[] { };
    public static string[] pu6 = new string[] { };
    public static string[] pu7 = new string[] { };
    public static string[] pu8 = new string[] { };
    public static string[] pe2 = new string[] { };
    public static string[] pe3 = new string[] { };
    public static string[] pe4 = new string[] { };
    public static string[] pe5 = new string[] { };
    public static string[] pe6 = new string[] { };
    public static string[] pe7 = new string[] { };
    public static string[] pe8 = new string[] { };
    public static string[] po2 = new string[] { };
    public static string[] po3 = new string[] { };
    public static string[] po4 = new string[] { };
    public static string[] po5 = new string[] { };
    public static string[] po6 = new string[] { };
    public static string[] po7 = new string[] { };
    public static string[] po8 = new string[] { };
    
    
    public Dictionary<string, string[]> sound50Index = new Dictionary<string, string[]>()
    {
        {"あ", a}, {"い", i}, {"う", u}, {"え", e}, {"お", o},
        {"か", ka}, {"き", ki}, {"く", ku}, {"け", ke}, {"こ", ko},
        {"さ", sa}, {"し", si}, {"す", su}, {"せ", se}, {"そ", so},
        {"た", ta}, {"ち", ti}, {"つ", tu}, {"て", te}, {"と", to},
        {"な", na}, {"に", ni}, {"ぬ", nu}, {"ね", ne}, {"の", no},
        {"は", ha}, {"ひ", hi}, {"ふ", hu}, {"へ", he}, {"ほ", ho},
        {"ま", ma}, {"み", mi}, {"む", mu}, {"め", me}, {"も", mo},
        {"や", ya}, {"ゆ", yu}, {"よ", yo},
        {"ら", ra}, {"り", ri}, {"る", ru}, {"れ", re}, {"ろ", ro},
        {"わ", wa}
    }; 
}
