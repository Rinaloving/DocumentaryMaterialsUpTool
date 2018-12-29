using DataConvert.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.MyTool
{
    class MyUtil
    {
        /// <summary>
        /// 返回dataName对应的dataNo
        /// </summary>
        /// <param name="dateName"></param>
        /// <returns></returns>
        public  static string getDataNo(string dateName)
        {
            switch (dateName)
            {
                case "发生转移事实的证明材料": return "050"; break;
                case "权属来源证明材料": return "001"; break;
                case "权籍调查表": return "002"; break;
                case "宗地图": return "003"; break;
                case "申请人身份证明材料": return "004"; break;
                case "集体土地所有权变更证明材料": return "005"; break;
                case "宗地界址坐标": return "006"; break;
                case "法律、行政法规规定的其他必要材料": return "007"; break;
                case "建设工程规划许可证": return "008"; break;
                case "房屋竣工备案证明": return "009"; break;
                case "房地产调查或者测绘报告": return "010"; break;
                case "义务人身份证件": return "011"; break;
                case "不动产登记申请书": return "012"; break;
                case "村民委员会同意的证明材料": return "036"; break;
                case "不动产登记簿记载错误的证明材料": return "037"; break;
                case "权利人同意更正的证明材料": return "038"; break;
                case "利害关系证明材料": return "039"; break;
                case "权利人不同意更正的证明材料": return "040"; break;
                case "已登记备案的商品房预售合同": return "041"; break;
                case "当事人关于预告登记的约定": return "042"; break;
                case "预售许可证等证明材料": return "043"; break;
                case "债权消灭证明材料": return "044"; break;
                case "查封裁定书": return "045"; break;
                case "预查封裁定书": return "046"; break;
                case "协助执行通知书": return "047"; break;
                case "登报声明": return "048"; break;
                case "集体土地所有权转移的证明材料": return "049"; break;
                case "抵押与债权合同": return "013"; break;
                case "不动产登记证明": return "014"; break;
                case "作价协议书或评估备案表": return "026"; break;
                case "国有建设用地使用权划拨决定书": return "015"; break;
                case "买卖合同": return "028"; break;
                case "不动产权属发生转移的证明材料": return "027"; break;
                case "土地承包经营合同、承包方案": return "016"; break;
                case "属于本集体经济组织农户的证明材料": return "017"; break;
                case "完税证明": return "029"; break;
                case "不动产初始登记转让许可材料": return "030"; break;
                case "人民政府或者主管部门的批准文件": return "031"; break;
                case "土地使用权出让合同及补充协议": return "032"; break;
                case "不动产抵押登记证明": return "033"; break;
                case "抵押权消灭的证明材料": return "034"; break;
                case "土地消灭的证明材料": return "035"; break;
                case "本邻宗法人身份证明": return "018"; break;
                case "法人资格证明及法定代表人身份证明书": return "019"; break;
                case "国有建设用地权利取得证明文件": return "020"; break;
                case "缴费收税证明": return "021"; break;
                case "企业营业执照": return "022"; break;
                case "不动产权证": return "023"; break;
                case "组织机构代码证": return "024"; break;
                case "委托书": return "025"; break;
                case "发生变更事实的证明材料": return "051"; break;
                case "登记范围内原不动产权证书注销证明": return "053"; break;
                case "补缴土地出让金凭证、缴税证明、公有住房出售票据": return "061"; break;
                case "建设项目竣工验收报告": return "055"; break;
                case "房地产地址证明": return "056"; break;
                case "房改房买卖契约": return "062"; break;
                case "不动产析产协议": return "063"; break;
                case "继承权协议书、遗嘱书": return "064"; break;
                case "生效的房屋赠与书或合同、接受书或遗赠书": return "065"; break;
                case "相关部门的通知书或裁决书": return "066"; break;
                case "夫妻双方财产约定协议书": return "067"; break;
                case "夫妻一方放弃产权协议书": return "068"; break;
                case "原证书登记查询证明资料": return "070"; break;
                case "注销不动产权的原因材料": return "071"; break;
                case "主债权合同": return "072"; break;
                case "当事人同意办理的书面约定": return "073"; break;
                case "抵押人出具的还款证明材料": return "074"; break;
                case "设定地役权协议": return "075"; break;
                case "购房票据证明": return "054"; break;
                case "不动产权籍调查资料": return "060"; break;
                case "土地使用权出让合同及补充协议、土地交付确认书": return "052"; break;
                case "公有住房房改房审批表": return "057"; break;
                case "公司章程、股东会决议": return "058"; break;
                case "同意抵押的书面材料": return "059"; break;
                case "不动产证": return "083"; break;
                case "原土地证": return "076"; break;
                case "规划条件": return "078"; break;
                case "用地建设相关证件": return "079"; break;
                case "不动产权籍调查报告": return "080"; break;
                case "变更前抵押合同与债权合同": return "081"; break;
                case "变更后抵押合同与债权合同": return "082"; break;
                case "抵押合同": return "087"; break;
                case "法院裁定书": return "091"; break;
                case "林地（林木）家庭承包合同书": return "088"; break;
                case "公示公告证明材料": return "089"; break;
                case "不动产登记审批意见": return "100"; break;
                case "不动产买卖合同、不动产权属证书等证明材料": return "084"; break;
                case "买卖发票或收据": return "085"; break;
                case "当事人同意办理预告登记的书面约定": return "086"; break;
                case "不动产登记审批表": return "201"; break;
                case "不动产权调查资料": return "202"; break;
                case "不动产权证书原件及复印件": return "203"; break;
                case "查档记录表": return "204"; break;
                case "房产测绘报告": return "206"; break;
                case "房屋买卖合同或其他证明不动产权发生转移德材料": return "207"; break;
                case "购房发票": return "208"; break;
                case "其他": return "209"; break;
                case "商品房用地宗地分割转让登记证明": return "210"; break;
                case "授权委托书及委托人身份证复印件": return "211"; break;
                case "双方申请人身份证明": return "212"; break;
                case "完税证明及税费发票复印件": return "213"; break;
                case "不动产登记申请表": return "200"; break;
                default:
                    return "";break;
            }
        }
        /// <summary>
        /// 判断文件夹下是否存在图片（图片的个数）0张返回true否则返回false
        /// </summary>
        /// <returns></returns>
        public static bool isPicNull(int picNum)
        {
            if (picNum == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 给起始页和当前页数赋值的方法
        /// </summary>
        /// <param name="currentCaseName"></param>
        /// <param name="lastCaseName"></param>
        /// <param name="rec"></param>
        /// <param name="fileLength"></param>
        public static void setStartPageAndPageNum(string currentCaseName, string lastCaseName, RECDATA rec, int fileLength, string[] files, string newName)
        {
            if (rec.DATANAME.Equals(currentCaseName) && MyUtil.isPicNull(fileLength))
                    {
                       
                        rec.PAGENUM = 0;
                        rec.STARTPAGE = 0;
                    }
                    else
                    {
                        IList<RECDATA> recdata = SystemHandler.Instance.EstateContext.GetList<RECDATA>("where CASENUM='" + rec.CASENUM + "'order by DATANO");
                        RECDATA recdata2 = SystemHandler.Instance.EstateContext.GetEntity<RECDATA>("CASENUM", rec.CASENUM);//上个业务
                        IList<RECDATA> recdata3 = SystemHandler.Instance.EstateContext.GetList<RECDATA>("where CASENUM='" + rec.CASENUM + "'and DATANAME = '"+currentCaseName+"'");//本次业务是否在不动产库存在

                        if (recdata2==null && !recdata2.DATANAME.Equals(lastCaseName))
                        {
                            rec.PAGENUM = files.Length;
                            rec.STARTPAGE = 1;
                        }
                        else
                        {
                            if (recdata3.Count==0)
                            {
                                rec.RECDATAID = newName;
                                rec.STARTPAGE = recdata[recdata.Count() - 1].STARTPAGE + recdata[recdata.Count() - 1].PAGENUM;
                                rec.PAGENUM = files.Length;
                                if (newName!="")
                                {
                                    try
                                    {
                                        SystemHandler.Instance.EstateContext.Add(rec);
                                    }
                                    catch (Exception)
                                    {

                                        throw;
                                    }
                                  
                                }
                               
                            }
                            
                        }
                       
                    }
        }
    }
}
