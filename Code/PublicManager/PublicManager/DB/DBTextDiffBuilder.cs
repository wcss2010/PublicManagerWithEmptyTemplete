using Noear.Weed;
using PublicManager.DB;
using System;
using System.Collections.Generic;
using System.Text;

namespace PublicManager.DB
{
    public class DBTextDiffBuilder : DBContentBuilder<string>
    {
        private const string tableLine = "***===***";
        private const string itemLine = "###===###";

        /// <summary>
        /// 生成数据文本
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override string getDBContent(Noear.Weed.DbContext context)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                DataItem diProject = context.table("JiBenXinXiBiao").select("*").getDataItem();
                //生成项目信息
                sb.Append("项目名称:").AppendLine(getStringWithEmptyCheck(diProject, "XiangMuMingCheng"));
                sb.Append("研究目标:").AppendLine(getStringWithEmptyCheck(diProject, "YanJiuMuBiao"));
                sb.Append("研究内容:").AppendLine(getStringWithEmptyCheck(diProject, "YanJiuNeiRong"));
                sb.Append("预期成果:").AppendLine(getStringWithEmptyCheck(diProject, "YuQiChengGuo"));
                sb.Append("研究周期:").AppendLine(getStringWithEmptyCheck(diProject, "YanJiuZhouQi"));
                sb.Append("经费概算:").AppendLine(getStringWithEmptyCheck(diProject, "JingFeiYuSuan"));
                sb.Append("项目类别:").AppendLine(getStringWithEmptyCheck(diProject, "XiangMuLeiBie"));
                sb.Append("课题类别:").AppendLine(getStringWithEmptyCheck(diProject, "ZhuanYeLeiBie"));
                sb.Append("责任单位:").AppendLine(getStringWithEmptyCheck(diProject, "ZeRenDanWei"));
                sb.Append("下级单位:").AppendLine(getStringWithEmptyCheck(diProject, "XiaJiDanWei"));
                sb.Append("牵头人:").AppendLine(getStringWithEmptyCheck(diProject, "QianTouRen"));
                sb.Append("牵头人性别:").AppendLine(getStringWithEmptyCheck(diProject, "QianTouRenXingBie"));
                sb.Append("牵头人民族:").AppendLine(getStringWithEmptyCheck(diProject, "QianTouRenMinZu"));
                sb.Append("牵头人出生年月:").AppendLine(getStringWithEmptyCheck(diProject, "QianTouRenShengRi"));
                sb.Append("部职别:").AppendLine(getStringWithEmptyCheck(diProject, "BuZhiBie"));
                sb.Append("联合研究单位:").AppendLine(getStringWithEmptyCheck(diProject, "LianHeYanJiuDanWei"));
                //sb.Append("审请经费:").AppendLine(getStringWithEmptyCheck(diProject, "ShenQingJingFei"));
                sb.Append("计划完成时间:").AppendLine(getStringWithEmptyCheck(diProject, "JiHuaWanChengShiJian"));
                sb.Append("备注:").AppendLine(getStringWithEmptyCheck(diProject, "BeiZhu"));
                sb.AppendLine(tableLine);
                //生成人员信息
                DataList dlPersons = context.table("RenYuanBiao").select("*").getDataList();
                bool needBottomLine = false;
                foreach (DataItem di in dlPersons.getRows())
                {
                    if (needBottomLine)
                    {
                        needBottomLine = false;
                        sb.AppendLine(itemLine);
                    }
                    string personName = getStringWithEmptyCheck(di, "XingMing");
                    sb.Append("姓名:").Append(personName).Append(" ");
                    sb.Append("性别:").Append(getStringWithEmptyCheck(di, "XingBie")).Append(" ");
                    sb.Append("出生年月:").Append(getStringWithEmptyCheck(di, "ShengRi")).Append(" ");
                    sb.Append("身份证号:").Append(getStringWithEmptyCheck(di, "ShenFenZhengHao")).Append(" ");
                    sb.Append("专业职务:").Append(getStringWithEmptyCheck(di, "ZhuanYeZhiWu")).Append(" ");
                    sb.Append("研究专长:").Append(getStringWithEmptyCheck(di, "YanJiuZhuanChang")).Append(" ");
                    sb.Append("工作单位:").Append(getStringWithEmptyCheck(di, "GongZuoDanWei"));
                    needBottomLine = true;
                }
                sb.AppendLine(tableLine);
                DataList dlMoneys = context.table("YuSuanBiao").select("*").getDataList();
                Dictionary<string, string> dictMoneys = new Dictionary<string, string>();
                foreach (DataItem di in dlMoneys.getRows())
                {
                    string dName = getStringWithEmptyCheck(di, "MingCheng");
                    string dValue = getStringWithEmptyCheck(di, "ShuJu");
                    dictMoneys[dName] = dValue;
                }
                sb.Append("设备费:").Append(dictMoneys["Money1"]).Append(",备注：").AppendLine(dictMoneys["Info1"]);
                sb.Append("材料费:").Append(dictMoneys["Money2"]).Append(",备注：").AppendLine(dictMoneys["Info2"]);
                sb.Append("外部协作费:").Append(dictMoneys["Money3"]).Append(",备注：").AppendLine(dictMoneys["Info3"]);
                sb.Append("燃料动力费:").Append(dictMoneys["Money4"]).Append(",备注：").AppendLine(dictMoneys["Info4"]);
                sb.Append("会议、差旅、国际合作与交流费:").Append(dictMoneys["Money5"]).Append(",备注：").AppendLine(dictMoneys["Info5"]);
                sb.Append("出版、文献、信息传播、知识产权事务费:").Append(dictMoneys["Money6"]).Append(",备注：").AppendLine(dictMoneys["Info6"]);
                sb.Append("劳务费:").Append(dictMoneys["Money7"]).Append(",备注：").AppendLine(dictMoneys["Info7"]);
                sb.Append("专家咨询费:").Append(dictMoneys["Money8"]).Append(",备注：").AppendLine(dictMoneys["Info8"]);
                sb.Append("其他支出:").Append(dictMoneys["Money9"]).Append(",备注：").AppendLine(dictMoneys["Info9"]);
                sb.Append("管理费:").Append(dictMoneys["Money10"]).Append(",备注：").AppendLine(dictMoneys["Info10"]);
                sb.Append("其它费用:").Append(dictMoneys["Money11"]).Append(",备注：").AppendLine(dictMoneys["Info11"]);
                sb.Append("第一年费用:").AppendLine(dictMoneys["Year1"]);
                sb.Append("第二年费用:").AppendLine(dictMoneys["Year2"]);
                sb.Append("第三年费用:").AppendLine(dictMoneys["Year3"]);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }
            return sb.ToString();
        }

        private string getStringWithEmptyCheck(DataItem diData, string pName)
        {
            return diData.get(pName) != null ? diData.get(pName).ToString().Replace(Environment.NewLine, string.Empty).Replace("\n", string.Empty).Replace("\r", string.Empty) : string.Empty;
        }

        public string getDiffContent(string source, string dest)
        {
            StringBuilder sb = new StringBuilder();
            string[] sourceData = source.Split(new string[] { tableLine }, StringSplitOptions.None);
            string[] destData = dest.Split(new string[] { tableLine }, StringSplitOptions.None);
            if (sourceData != null && destData != null && sourceData.Length == destData.Length)
            {
                for (int k = 0; k < sourceData.Length; k++)
                {
                    string itemA = sourceData[k];
                    string itemB = destData[k];
                    if (itemA.Contains(itemLine))
                    {
                        //人员
                        string[] personAItems = itemA.Split(new string[] { itemLine }, StringSplitOptions.None);
                        string[] personBItems = itemB.Split(new string[] { itemLine }, StringSplitOptions.None);
                        if (personAItems != null && personBItems != null)
                        {
                            List<string> pAList = new List<string>();
                            pAList.AddRange(personAItems);
                            List<string> pBList = new List<string>();
                            pBList.AddRange(personBItems);

                            //检查删除
                            foreach (string s in pAList)
                            {
                                if (pBList.Contains(s))
                                {
                                    //存在
                                    continue;
                                }
                                else
                                {
                                    sb.AppendLine("删除人员>>>");
                                    sb.AppendLine(s.Trim());
                                }
                            }
                            //检查添加
                            foreach (string s in pBList)
                            {
                                if (pAList.Contains(s))
                                {
                                    //存在
                                    continue;
                                }
                                else
                                {
                                    sb.AppendLine("添加人员>>>");
                                    sb.AppendLine(s.Trim());
                                }
                            }
                        }
                    }
                    else
                    {
                        //其它
                        string[] itemAItems = itemA.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                        string[] itemBItems = itemB.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                        if (itemAItems != null && itemBItems != null)
                        {
                            List<string> ddd = new List<string>();
                            ddd.AddRange(itemAItems);
                            foreach (string s in itemBItems)
                            {
                                if (ddd.Contains(s))
                                {
                                    //没变
                                }
                                else
                                {
                                    sb.Append("修改属性>>>");
                                    sb.AppendLine(s.Trim());
                                }
                            }
                        }
                    }
                }
            }
            return sb.ToString();
        }
    }
}